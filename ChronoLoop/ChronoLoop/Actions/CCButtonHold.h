#pragma once

#include "../Objects/BaseObject.h"
#include "CodeComponent.hpp"
#include "..\Physics\Physics.h"
#include "..\Common\Logger.h"
#include "../Core/Level.h"
#include "../Core/TimeManager.h"
#include "../Core/LevelManager.h"

namespace Epoch
{

	struct CCButtonHold : public CodeComponent
	{
		bool colliding = false, mhitting = false, mCanDoorInterp = false, mDoorDoneInterpolating = false, mFlip = false, mSoundOnce = false;;
		bool tempDoor = false;
		BaseObject *Block = nullptr, *Exit = nullptr;
		CubeCollider* blockCube, *exitCube;
		matrix4 blockend, exitend , blockstart, exitstart;
		Interpolator<matrix4>* blockInterp;
		Interpolator<matrix4>* exitInterp;
		//vec3f blockend, exitend;


		Level* cLevel;
		void SetDoorInterpBool(bool _set) { mCanDoorInterp = _set; };
		bool GetDoorInterpBool() { return mCanDoorInterp; };
		virtual void Start()
		{

			cLevel = LevelManager::GetInstance().GetCurrentLevel();
			Block = cLevel->FindObjectWithName("TransparentDoor1");
			Exit = cLevel->FindObjectWithName("TransparentDoor2");
			blockInterp = TimeManager::Instance()->GetObjectInterpolator(Block->GetUniqueID());
			exitInterp = TimeManager::Instance()->GetObjectInterpolator(Exit->GetUniqueID());

			blockCube = (CubeCollider*)Block->mComponents[eCOMPONENT_COLLIDER][0];
			exitCube = (CubeCollider*)Exit->mComponents[eCOMPONENT_COLLIDER][0];
			//blockend = blockCube->GetPos() - vec3f(0, 2.6f, 0);
			//exitend = exitCube->GetPos() + vec3f(0, 2.6f, 0);
			blockstart = blockCube->GetTransform().GetMatrix();
			exitstart = exitCube->GetTransform().GetMatrix();
			blockend = blockCube->GetTransform().GetMatrix() * blockCube->GetTransform().GetMatrix().CreateTranslation(vec4f(0, 2.6f, 0, 1));
			exitend = exitCube->GetTransform().GetMatrix() * exitCube->GetTransform().GetMatrix().CreateTranslation(vec4f(0, -2.6f, 0, 1));
		}

		virtual void OnCollision(Collider& _col, Collider& _other, float _time)
		{
			if (!colliding && _other.mColliderType != Collider::eCOLLIDER_Plane && ((Component*)&_other)->GetBaseObject()->GetName() != "Buttonstand" && !Settings::GetInstance().GetBool("PauseMenuUp"))
			{
				colliding = true;
				//SystemLogger::GetLog() << "Colliding" << std::endl;
				//Interp stuff
				ButtonCollider* butCol = (ButtonCollider*)mObject->GetComponentIndexed(eCOMPONENT_COLLIDER, 0);
				if (butCol->mPushNormal * _other.mVelocity < .1f)
					_col.mVelocity = vec3f(0, 0, 0);

				if (!tempDoor) {
					blockInterp->SetActive(true);
					blockInterp->Prepare(0.69f, blockCube->GetTransform().GetMatrix(), blockend, blockCube->GetTransform().GetMatrix());

					//exitCube->SetPos(exitend);
					exitInterp->SetActive(true);
					exitInterp->Prepare(0.69f, exitCube->GetTransform().GetMatrix(), exitend, exitCube->GetTransform().GetMatrix());

					((Collider*)blockCube->GetBaseObject()->GetComponentIndexed(eCOMPONENT_COLLIDER, 0))->SetPos(blockend.Position);
					((Collider*)exitCube->GetBaseObject()->GetComponentIndexed(eCOMPONENT_COLLIDER, 0))->SetPos(exitend.Position);

					mCanDoorInterp = true;
					mDoorDoneInterpolating = false;
					tempDoor = true;
				}

				// Sound 
				if (!mSoundOnce) {
					if (_col.GetBaseObject()->GetComponentCount(eCOMPONENT_AUDIOEMITTER) > 0) {
						if (dynamic_cast<SFXEmitter*>(_col.GetBaseObject()->GetComponentIndexed(eCOMPONENT_AUDIOEMITTER, 0)))
							((SFXEmitter*)_col.GetBaseObject()->GetComponentIndexed(eCOMPONENT_AUDIOEMITTER, 0))->CallEvent();
					}

					if (Block->GetComponentCount(eCOMPONENT_AUDIOEMITTER) > 0) {
						if (dynamic_cast<SFXEmitter*>(Block->GetComponentIndexed(eCOMPONENT_AUDIOEMITTER, 0)))
							((SFXEmitter*)Block->GetComponentIndexed(eCOMPONENT_AUDIOEMITTER, 0))->CallEvent();
					}
					if (Exit->GetComponentCount(eCOMPONENT_AUDIOEMITTER) > 0) {
						if (dynamic_cast<SFXEmitter*>(Exit->GetComponentIndexed(eCOMPONENT_AUDIOEMITTER, 0)))
							((SFXEmitter*)Exit->GetComponentIndexed(eCOMPONENT_AUDIOEMITTER, 0))->CallEvent();
					}
				}
				mSoundOnce = true;

				vec3f norm = ((ButtonCollider*)&_col)->mPushNormal;
				vec3f tForce = norm * (norm * _other.mTotalForce);
				vec3f vel = norm * (norm * _other.mVelocity);
				vec3f accel = norm * (norm * _other.mAcceleration);
				if (tForce * norm < 0 && vel * norm < 0 && accel * norm < 0)
				{
					_col.mTotalForce = tForce;
					_col.mVelocity = vel;
					_col.mAcceleration = vel / _time;
					//blockCube->SetPos(blockend);
				}
			}
			
		}
		virtual void Update()
		{
			if (!LevelManager::GetInstance().GetCurrentLevel()->GetTimeManipulator()->isTimePaused()) {
				if (colliding)
				{
					//SystemLogger::GetLog() << "Colliding" << std::endl;
					mFlip = true;
					if (mCanDoorInterp && !mDoorDoneInterpolating)
					{
						mDoorDoneInterpolating = (blockInterp->Update(TimeManager::Instance()->GetDeltaTime()) || exitInterp->Update(TimeManager::Instance()->GetDeltaTime()));
					}
					else
					{
						mCanDoorInterp = false;
						blockInterp->SetActive(false);
						exitInterp->SetActive(false);
					}
				}
				else
				{
					tempDoor = false;
					//SystemLogger::GetLog() << "Not Colliding" << std::endl;
					if(mFlip)
					{
						mFlip = false;
						blockInterp->SetActive(true);
						blockInterp->Prepare(0.69f, blockCube->GetTransform().GetMatrix(), blockstart, blockCube->GetTransform().GetMatrix());

						exitInterp->SetActive(true);
						exitInterp->Prepare(0.69f, exitCube->GetTransform().GetMatrix(), exitstart, exitCube->GetTransform().GetMatrix());
						((Collider*)blockCube->GetBaseObject()->GetComponentIndexed(eCOMPONENT_COLLIDER, 0))->SetPos(blockstart.Position);
						((Collider*)exitCube->GetBaseObject()->GetComponentIndexed(eCOMPONENT_COLLIDER, 0))->SetPos(exitstart.Position);

						mCanDoorInterp = true;
						mDoorDoneInterpolating = false;
					}

					if (mCanDoorInterp && !mDoorDoneInterpolating)
					{
						mDoorDoneInterpolating = (blockInterp->Update(TimeManager::Instance()->GetDeltaTime()) || exitInterp->Update(TimeManager::Instance()->GetDeltaTime()));
					}
					else
					{
						mCanDoorInterp = false;
						blockInterp->SetActive(false);
						exitInterp->SetActive(false);
					}
					mSoundOnce = false;
				}
			}
			colliding = false;
		}
	};
}
