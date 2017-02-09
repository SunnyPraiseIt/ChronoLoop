///////////////////////////////////////
//Written: 2/8/2017
//Author: Chris Burt
///////////////////////////////////////

#include "stdafx.h"
#include "Physics.h"


bool SameSign(float _f1, float _f2)
{
	if ((_f1 > 0 && _f2 > 0) || (_f1 < 0 && _f2 < 0))
		return true;
	return false;
}


#pragma region RAY_CASTING

bool Physics::RayToTriangle(vec4f& _vert0, vec4f& _vert1, vec4f& _vert2, vec4f& _normal, vec4f& _start, vec4f& _dir, float& _time)
{
	if (((_normal * _dir) > 0 || (_vert0 - _start) * _normal) > 0)
		return false;

	vec4f sa = _vert0 - _start;
	vec4f sb = _vert1 - _start;
	vec4f sc = _vert2 - _start;
	vec4f N1, N2, N3;
	N1 = sc ^ sb;
	N2 = sa ^ sc;
	N3 = sb ^ sa;
	float dn1 = _dir * N1;
	float dn2 = _dir * N2;
	float dn3 = _dir * N3;

	if (dn1 == 0.0f && dn2 == 0.0f && dn3 == 0.0f)
	{
		_time = 0;
		return false;
	}

	if (SameSign(dn1, dn2) && SameSign(dn2, dn3))
	{
		float offset = _normal * _vert0;
		_time = ((offset - (_start * _normal)) / (_normal * _dir));
		return true;
	}
}

bool Physics::RayToSphere(vec4f& _pos, vec4f& _dir, vec4f& _center, float _radius, float& _time, vec4f& _out)
{
	vec4f check = _pos - _center;

	vec4f m = _pos - _center;
	float b = m * _dir;
	float c = (m * m) - (_radius * _radius);
	if (c < 0.0f || b > 0.0f)
		return false;

	float dis = b*b - c;
	if (dis < 0.0f)
		return false;

	_time = -b - sqrt(dis);
	if (_time < 0.0f)
	{
		_time = 0.0f;
		vec4f np = { _pos.data.x + _time, _pos.data.y + _time, _pos.data.z + _time, 1.0f };
		_out = np ^ _dir;
	}

	return true;
}

bool Physics::RayToCylinder(vec4f& _start, vec4f& _normal, vec4f& _point1, vec4f& _point2, float _radius, float& _time)
{
	vec4f d = _point2 - _point1;
	vec4f od = _point1 - _point2;
	vec4f m = _start - _point1; 

	float dd = d * d;
	float nd = _normal * d;
	float mn = m * _normal;
	float md = m * d;
	float mm = m * m;

	if ((md < 0 && nd < 0) || (md > dd && nd > 0))
		return false;

	float a = dd - nd * nd;
	float b = dd * mn - nd * md;
	float c = dd * (mm - _radius * _radius) - md * md;

	if (abs(a) < FLT_EPSILON)
		return false;

	float dis = b*b - a*c;
	if (dis < 0)
		return false;

	_time = (-b - sqrt(dis)) / a;

	if (_time < 0)
		return false;

	vec4f col = _start + _normal * _time;

	if (od * (_point2 - col) > 0 || d * (_point1 - col) > 0)
		return false;

	return true;
}

bool Physics::RayToCapsule(vec4f& _start, vec4f& _normal, vec4f& _point1, vec4f& _point2, float _radius, float& _time)
{
	float fTime = FLT_MAX;
	_time = FLT_MAX;
	bool bReturn = false;

	if (RayToCylinder(_start, _normal, _point1, _point2, _radius, _time))
	{
		fTime = min(_time, fTime);
		_time = fTime;
		bReturn = true;
	}

	vec4f pcol, qcol;
	if (RayToSphere(_start, _normal, _point1, _radius, _time, pcol))
	{
		fTime = min(_time, fTime);
		_time = fTime;
		bReturn = true;
	}

	if (RayToSphere(_start, _normal, _point2, _radius, _time, qcol))
	{
		fTime = min(_time, fTime);
		_time = fTime;
		bReturn = true;
	}
	return bReturn;
}

#pragma endregion


#pragma region MOVING_SPHERE

bool Physics::MovingSphereToTriangle(vec4f& _vert0, vec4f& _vert1, vec4f& _vert2, vec4f& _normal, vec4f& _start, vec4f& _dir, float _radius, float& _time, vec4f& _outNormal)
{
	bool bReturn = false;
	float fTime = FLT_MAX;
	_time = FLT_MAX;

	vec4f verts[3] = { _vert0, _vert1, _vert2 };
	vec4f offset0 = _vert0 + (_normal * _radius);
	vec4f offset1 = _vert1 + (_normal * _radius);
	vec4f offset2 = _vert2 + (_normal * _radius);

	if (RayToTriangle(offset0, offset1, offset2, _normal, _start, _dir, _time))
	{
		fTime = min(_time, fTime);
		_time = fTime;
		_outNormal = _normal;
		bReturn = true;
	}
	else
	{
		if (RayToCapsule(_start, _dir, _vert0, _vert1, _radius, _time))
		{
			fTime = min(_time, fTime);
			_time = fTime;
			vec4f temp1 = _dir * _time + _start;
			vec4f temp2 = (_vert1 - _vert0) * _time + _vert0;
			_outNormal = (temp1 - temp2).Normalize();
			bReturn = true;
		}

		if (RayToCapsule(_start, _dir, _vert1, _vert2, _radius, _time))
		{
			fTime = min(_time, fTime);
			_time = fTime;
			vec4f temp1 = _dir * _time + _start;
			vec4f temp2 = (_vert1 - _vert0) * _time + _vert0;
			_outNormal = (temp1 - temp2).Normalize();
			bReturn = true;
		}

		if (RayToCapsule(_start, _dir, _vert2, _vert0, _radius, _time))
		{
			fTime = min(_time, fTime);
			_time = fTime;
			vec4f temp1 = _dir * _time + _start;
			vec4f temp2 = (_vert1 - _vert0) * _time + _vert0;
			_outNormal = (temp1 - temp2).Normalize();
			bReturn = true;
		}
	}

	return bReturn;
}

bool Physics::MovingSphereToMesh(vec4f& _start, vec4f& _dir, float _radius, ED2Mesh* _mesh, float& _time, vec4f& _outNormal)
{
	bool bCollision = false;
	_time = FLT_MAX;
	float fTime = FLT_MAX;
	
	unsigned int tempSortedIndicies[3] = { 0,0,0 };

	for (unsigned int i = 0; i < mesh->m_Triangles.size(); i++) {

		ED2Triangle currTri = mesh->m_Triangles[i];
		vec4f currNorm = mesh->m_TriNorms[i];

		for (unsigned int x = 0; x < 3; x++) {
			tempSortedIndicies[x] = currTri.indices[x];
		}

		unsigned int temp = 0;
		for (unsigned int i = 1; i < 4; i++) {
			for (unsigned int j = 0; j < 3; j++) {
				if (tempSortedIndicies[j + 1] < tempSortedIndicies[j]) {
					temp = tempSortedIndicies[j];
					tempSortedIndicies[j] = tempSortedIndicies[j + 1];
					tempSortedIndicies[j + 1] = temp;
					break;
				}
			}
		}

		if (MovingSphereToTriangle(
			mesh->m_Vertices[tempSortedIndicies[0]].pos,
			mesh->m_Vertices[tempSortedIndicies[1]].pos,
			mesh->m_Vertices[tempSortedIndicies[2]].pos,
			currNorm, _start, _dir, _radius, fTime, _outNormal))
		{
			_time = fminf(_time, fTime);
			_outNormal = currNorm;
			bCollision = true;
		}
	}

	return bCollision;
}

#pragma endregion


#pragma region PLANE_COLISION

void Physics::BuildPlane(Plane& _plane, vec4f _pointA, vec4f& _pointB, vec4f& _pointC)
{
	_plane.mNormal = (_pointA - _pointC) ^ (_pointB - _pointA);
	_plane.mNormal.Normalize();
	_plane.mOffset = _pointA * _plane.mNormal;
}

//Returns 1 if on or in front of plane
//Returns 2 if behind plane
int Physics::PointToPlane(Plane& _plane, vec4f& _point)
{
	float pOffset = _point * _plane.mNormal;
	if (pOffset >= _plane.mOffset)
		return 1;
	return 2;
}

//Returns 1 if in front of plane
//Returns 2 if behind plane
//Returns 3 if intersecting plane
int Physics::SphereToPlane(Plane& _plane, Sphere& _sphere)
{
	float pOffset = _sphere.mPosition * _plane.mNormal;
	if (pOffset - _plane.mOffset > _sphere.mRadius)
		return 1;
	else if (pOffset - _plane.mOffset < -_sphere.mRadius)
		return 2;
	return 3;
}

//Returns 1 if in front of plane.
//Returns 2 if behind plane.
//Returns 3 if intersecting plane.
int Physics::AabbToPlane(Plane & _plane, AABB & _aabb)
{
	vec4f center = (_aabb.mMax + _aabb.mMin) * 0.5f;
	float pOffset = center * _plane.mNormal - _plane.mOffset;
	vec4f E = _aabb.mMax - center;
	float r = E.data.x * abs(_plane.mNormal.data.x) + E.data.y * abs(_plane.mNormal.data.y) + E.data.z * abs(_plane.mNormal.data.z);

	if (pOffset > r)
		return 1;
	else if (pOffset < -r)
		return 2;
	return 3;
}

#pragma endregion


#pragma region FRUSTUM_COLLISION
/*
void Physics::BuildFrustum(Frustum& _frustum, float _fov, float _nearDist, float _farDist, float _ratio, matrix4& _camXform)
{
	vec4f fc = _camXform.axis_pos - _camXform.axis_z * _farDist;
	vec4f nc = _camXform.axis_pos - _camXform.axis_z * _nearDist;
	float Hnear = 2 * tan(_fov / 2) * _nearDist;
	float Hfar = 2 * tan(_fov / 2) * _farDist;
	float Wnear = Hnear * _ratio;
	float Wfar = Hfar * _ratio;

	_frustum.mPoints[0] = fc + _camXform.axis_y * (Hfar * 0.5f) - _camXform.axis_x * (Wfar * 0.5f);
	_frustum.mPoints[3] = fc + _camXform.axis_y * (Hfar * 0.5f) + _camXform.axis_x * (Wfar * 0.5f);
	_frustum.mPoints[1] = fc - _camXform.axis_y * (Hfar * 0.5f) - _camXform.axis_x * (Wfar * 0.5f);
	_frustum.mPoints[2] = fc - _camXform.axis_y * (Hfar * 0.5f) + _camXform.axis_x * (Wfar * 0.5f);
			   
	_frustum.mPoints[4] = nc + _camXform.axis_y * (Hnear * 0.5f) - _camXform.axis_x * (Wnear * 0.5f);
	_frustum.mPoints[5] = nc + _camXform.axis_y * (Hnear * 0.5f) + _camXform.axis_x * (Wnear * 0.5f);
	_frustum.mPoints[7] = nc - _camXform.axis_y * (Hnear * 0.5f) - _camXform.axis_x * (Wnear * 0.5f);
	_frustum.mPoints[6] = nc - _camXform.axis_y * (Hnear * 0.5f) + _camXform.axis_x * (Wnear * 0.5f);

	BuildPlane(_frustum.mFaces[0], _frustum.mPoints[6], _frustum.mPoints[7], _frustum.mPoints[4]);
	BuildPlane(_frustum.mFaces[1], _frustum.mPoints[1], _frustum.mPoints[2], _frustum.mPoints[3]);
	BuildPlane(_frustum.mFaces[2], _frustum.mPoints[7], _frustum.mPoints[1], _frustum.mPoints[0]);
	BuildPlane(_frustum.mFaces[3], _frustum.mPoints[2], _frustum.mPoints[6], _frustum.mPoints[5]);
	BuildPlane(_frustum.mFaces[4], _frustum.mPoints[5], _frustum.mPoints[4], _frustum.mPoints[0]);
	BuildPlane(_frustum.mFaces[5], _frustum.mPoints[7], _frustum.mPoints[6], _frustum.mPoints[2]);
}

bool Physics::FrustumToSphere(Frustum & _frustum, Sphere & _sphere)
{
	int test = 0;
	for (int i = 0; i < 6; ++i)
	{
		if (SphereToPlane(_frustum.mFaces[i], _sphere) == 2)
			break;
		else
			test++;
	}

	if (test == 6)
		return true;
	return false;
}

bool Physics::FrustumToAABB(Frustum & _frustum, AABB & _aabb)
{
	int test = 0;
	for (int i = 0; i < 6; ++i)
	{
		if (AabbToPlane(_frustum.mFaces[i], _aabb) == 2)
			break;
		else
			test++;
	}

	if (test == 6)
		return true;
	return false;
}
*/
#pragma endregion


#pragma region MISC_COLLISION

bool Physics::AABBtoAABB(AABB & _aabb1, AABB & _aabb2)
{
	if (_aabb1.mMax.data.x < _aabb2.mMin.data.x || _aabb1.mMin.data.x > _aabb2.mMax.data.x)
		return false;

	if (_aabb1.mMax.data.y < _aabb2.mMin.data.y || _aabb1.mMin.data.y > _aabb2.mMax.data.y)
		return false;

	if (_aabb1.mMax.data.z < _aabb2.mMin.data.z || _aabb1.mMin.data.z >  _aabb2.mMax.data.z)
		return false;

	return true;
}

bool Physics::SphereToSphere(Sphere & _sphere1, Sphere & _sphere2)
{
	vec4f pos = _sphere1.mPosition - _sphere2.mPosition;
	float distance = pos.data.x * pos.data.x + pos.data.y * pos.data.y + pos.data.z * pos.data.z;
	float minDist = _sphere1.mRadius + _sphere2.mRadius;

	return distance <= (minDist * minDist);
}

bool Physics::SphereToAABB(Sphere & _sphere, AABB & _aabb)
{
	float X, Y, Z;

	if (_sphere.mPosition.data.x < _aabb.mMin.data.x)
		X = _aabb.mMin.data.x;
	else if (_sphere.mPosition.data.x > _aabb.mMax.data.x)
		X = _aabb.mMax.data.x;
	else
		X = _sphere.mPosition.data.x;

	if (_sphere.mPosition.data.y < _aabb.mMin.data.y)
		Y = _aabb.mMin.data.y;
	else if (_sphere.mPosition.data.y > _aabb.mMax.data.y)
		Y = _aabb.mMax.data.y;
	else
		Y = _sphere.mPosition.data.y;

	if (_sphere.mPosition.data.z < _aabb.mMin.data.z)
		Z = _aabb.mMin.data.z;
	else if (_sphere.mPosition.data.z > _aabb.mMax.data.z)
		Z = _aabb.mMax.data.z;
	else
		Z = _sphere.mPosition.data.z;

	vec4f point = { X, Y, Z, 1.0f };

	return (abs((point.data.x - _sphere.mPosition.data.x)) < _sphere.mRadius &&
		abs((point.data.y - _sphere.mPosition.data.y)) < _sphere.mRadius &&
		abs((point.data.z - _sphere.mPosition.data.z)) < _sphere.mRadius);
}

#pragma endregion


vec4f Physics::AddForce(vec4f& _pos, vec4f _force, float _time)
{
	//vec4f temp = _pos
}