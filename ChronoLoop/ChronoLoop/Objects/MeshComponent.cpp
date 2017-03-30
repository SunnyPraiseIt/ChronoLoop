#include "MeshComponent.h"
#include "BaseObject.h"
#include "Component.h"
#include "../Rendering/RenderShape.h"
#include "../Rendering/Renderer.h"
#include "../Common/Settings.h"

namespace Epoch {
	void MeshComponent::CreateNode()
	{
		DESTROY_NODE(mNode);
		mNode = Renderer::Instance()->AddOpaqueNode(*mShape);
	}

	MeshComponent::MeshComponent(const char * _path) {
		mType = eCOMPONENT_MESH;
		mShape = new RenderShape(_path, true, ePS_TEXTURED, eVS_TEXTURED, eGS_PosNormTex);
		mShape->GetContext().mRasterState = eRS_FILLED;
		if (CanCreateNode()) {
			CreateNode();
			mVisible = true;
		}
		else
		{
			mVisible = false;
			mNode = nullptr;
		}
	}

	void MeshComponent::Update() {
		if (mNode && mVisible) 
		{
			if (mObject->GetParent())
				mNode->data = mObject->GetTransform().GetMatrix() * mObject->GetParent()->GetTransform().GetMatrix();
			else
				mObject->GetTransform().GetMatrix(mNode->data);
		}
	}

	void MeshComponent::Destroy() {
		SystemLogger::Debug() << "Destroying shape " << mShape->GetName() << std::endl;
		DESTROY_NODE(mNode);
		delete mShape;
	}

	MeshComponent* MeshComponent::SetVisible(bool _vis) {
		// TODO: Check to see if this is an efficient way to make meshes appear and disappear, because this involves
		// a bit of looping. It could possibly be more efficient to set a bool on the render shape saying it's
		// invisible.
		// Side thought: Make the render set actually a list of MeshComponents, since they have shapes and direct
		// access to the position of the object.
		if (_vis) {
			if (!mVisible) {
				//CreateNode();
				mVisible = true;
				if(mNode == nullptr && CanCreateNode())
				{
					CreateNode();
				}
				Update();
			}
		}
		else {
			if (mVisible) {
				//DESTROY_NODE(mNode);
				if(mNode)
				{
					memset(&mNode->data, 0, sizeof(mNode->data));
				}
				mVisible = false;
			}
		}
		return this;
	}

	MeshComponent* MeshComponent::AddTexture(const char * _path, TextureType _type) {
		DESTROY_NODE(mNode);
		mShape->AddTexture(_path, _type);
		if (mVisible) {
			CreateNode();
		}
		return this;
	}

	void MeshComponent::SetRasterState(RasterState _t) {
		if (_t != mShape->GetContext().mRasterState) {
			DESTROY_NODE(mNode);
			mShape->GetContext().mRasterState = _t;
			if (mVisible) {
				CreateNode();
			}
		}
	}

	void MeshComponent::SetVertexShader(VertexShaderFormat _vf)
	{
		if (_vf != mShape->GetContext().mGeoShaderFormat) {
			DESTROY_NODE(mNode);
			mShape->GetContext().mVertexShaderFormat = _vf;
			if (mVisible) {
				CreateNode();
			}
		}
	}

	void MeshComponent::SetPixelShader(PixelShaderFormat _pf)
	{
		if (_pf != mShape->GetContext().mGeoShaderFormat) {
			DESTROY_NODE(mNode);
			mShape->GetContext().mPixelShaderFormat = _pf;
			if (mVisible) {
				CreateNode();
			}
		}
	}

	void MeshComponent::SetGeometryShader(GeometryShaderFormat _gf)
	{
		if (_gf != mShape->GetContext().mGeoShaderFormat) {
			DESTROY_NODE(mNode);
			mShape->GetContext().mGeoShaderFormat = _gf;
			if (mVisible) {
				CreateNode();
			}
		}
	}

	RenderShape * MeshComponent::GetShape()
	{
		return mShape;
	}

	void MeshComponent::ForceReinsertion()
	{
		CreateNode();
	}

	bool MeshComponent::CanCreateNode()
	{
		return !Settings::GetInstance().GetBool("LevelIsLoading");
	}

}