#pragma once
#include <list>
#include <vector>
#include "Rendering\Structures.h"
#include "Common\FileIO.h"


struct ID3D11Texture2D;
struct ID3D11ShaderResourceView;
struct ID3D11Buffer;


struct GSParticle
{
	vec4f pos;
	float size;
	float pad[3];
};

struct GSMatrix
{
	matrix4 world, view, proj;
};

struct Particle
{
	int mLife;
	float mSize;
	vec4f mPos, mPrevPos, mVelocity;
	vec4f mColor, mPrevColor;
	bool mActive;
	
	//Constructors

	Particle(int _life, float _size, vec4f _pos, vec4f _color);
};

class ParticleEmitter
{
	long mID;
	char* mName;

private:
	ID3D11Texture2D* mTexture;
	ID3D11ShaderResourceView* mTextureView;
	ID3D11Buffer* mVBuffer, *mIBuffer;
	GSMatrix mLeft, mRight;
	//BlendMode
	//BoundingBox
	vec4f mPos;

	Particle* mBase;
	std::list<Particle*> mParticles;
	std::vector<GSParticle> mGParticles;
	int mTotalParticles, mMaxParticles, mPerSec;
	vec4f mStartColor, mEndColor;

	virtual void UpdateParticle(Particle* _p);
	void CreateBuffers();
	void CreateTexureResource();
	void UpdateBuffers();
	void CleanUpParticles();
	void EmitParticles();

public:
	ParticleEmitter(int _numParticles, int _totalp, int _maxp, int _persec, vec4f _pos);
	virtual ~ParticleEmitter();

	ID3D11Buffer* GetVertexBuffer();
	ID3D11Buffer* GetIndexBuffer();
	ID3D11ShaderResourceView* GetTexture();

	void SetTexture(ID3D11Texture2D* _tex);
	void SetLEye(matrix4 _world, matrix4 _view, matrix4 _proj);
	void SetREye(matrix4 _world, matrix4 _view, matrix4 _proj);
	virtual void SetParticle(Particle* _p);

	virtual void Update(float _delta);

};