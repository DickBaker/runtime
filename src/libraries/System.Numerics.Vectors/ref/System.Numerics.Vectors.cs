// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// ------------------------------------------------------------------------------
// Changes to this file must follow the https://aka.ms/api-review process.
// ------------------------------------------------------------------------------

namespace System.Numerics
{
    public partial struct Matrix3x2 : System.IEquatable<System.Numerics.Matrix3x2>
    {
        public float M11;
        public float M12;
        public float M21;
        public float M22;
        public float M31;
        public float M32;
        public Matrix3x2(float m11, float m12, float m21, float m22, float m31, float m32) { throw null; }
        public static System.Numerics.Matrix3x2 Identity { get { throw null; } }
        public readonly bool IsIdentity { get { throw null; } }
        public System.Numerics.Vector2 Translation { readonly get { throw null; } set { throw null; } }
        public System.Numerics.Vector2 X { readonly get { throw null; } set { throw null; } }
        public System.Numerics.Vector2 Y { readonly get { throw null; } set { throw null; } }
        public System.Numerics.Vector2 Z { readonly get { throw null; } set { throw null; } }
        public System.Numerics.Vector2 this[int row] { readonly get { throw null; } set { throw null; } }
        public float this[int row, int column] { readonly get { throw null; } set { throw null; } }
        public static System.Numerics.Matrix3x2 Add(System.Numerics.Matrix3x2 value1, System.Numerics.Matrix3x2 value2) { throw null; }
        public static Matrix3x2 Create(float value) { throw null; }
        public static Matrix3x2 Create(System.Numerics.Vector2 value) { throw null; }
        public static Matrix3x2 Create(System.Numerics.Vector2 x, System.Numerics.Vector2 y, System.Numerics.Vector2 z) { throw null; }
        public static Matrix3x2 Create(float m11, float m12, float m21, float m22, float m31, float m32) { throw null; }
        public static System.Numerics.Matrix3x2 CreateRotation(float radians) { throw null; }
        public static System.Numerics.Matrix3x2 CreateRotation(float radians, System.Numerics.Vector2 centerPoint) { throw null; }
        public static System.Numerics.Matrix3x2 CreateScale(System.Numerics.Vector2 scales) { throw null; }
        public static System.Numerics.Matrix3x2 CreateScale(System.Numerics.Vector2 scales, System.Numerics.Vector2 centerPoint) { throw null; }
        public static System.Numerics.Matrix3x2 CreateScale(float scale) { throw null; }
        public static System.Numerics.Matrix3x2 CreateScale(float scale, System.Numerics.Vector2 centerPoint) { throw null; }
        public static System.Numerics.Matrix3x2 CreateScale(float xScale, float yScale) { throw null; }
        public static System.Numerics.Matrix3x2 CreateScale(float xScale, float yScale, System.Numerics.Vector2 centerPoint) { throw null; }
        public static System.Numerics.Matrix3x2 CreateSkew(float radiansX, float radiansY) { throw null; }
        public static System.Numerics.Matrix3x2 CreateSkew(float radiansX, float radiansY, System.Numerics.Vector2 centerPoint) { throw null; }
        public static System.Numerics.Matrix3x2 CreateTranslation(System.Numerics.Vector2 position) { throw null; }
        public static System.Numerics.Matrix3x2 CreateTranslation(float xPosition, float yPosition) { throw null; }
        public readonly bool Equals(System.Numerics.Matrix3x2 other) { throw null; }
        public override readonly bool Equals([System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] object? obj) { throw null; }
        public readonly float GetDeterminant() { throw null; }
        public readonly float GetElement(int row, int column) { throw null; }
        public readonly System.Numerics.Vector2 GetRow(int index) { throw null; }
        public override readonly int GetHashCode() { throw null; }
        public static bool Invert(System.Numerics.Matrix3x2 matrix, out System.Numerics.Matrix3x2 result) { throw null; }
        public static System.Numerics.Matrix3x2 Lerp(System.Numerics.Matrix3x2 matrix1, System.Numerics.Matrix3x2 matrix2, float amount) { throw null; }
        public static System.Numerics.Matrix3x2 Multiply(System.Numerics.Matrix3x2 value1, System.Numerics.Matrix3x2 value2) { throw null; }
        public static System.Numerics.Matrix3x2 Multiply(System.Numerics.Matrix3x2 value1, float value2) { throw null; }
        public static System.Numerics.Matrix3x2 Negate(System.Numerics.Matrix3x2 value) { throw null; }
        public static System.Numerics.Matrix3x2 operator +(System.Numerics.Matrix3x2 value1, System.Numerics.Matrix3x2 value2) { throw null; }
        public static bool operator ==(System.Numerics.Matrix3x2 value1, System.Numerics.Matrix3x2 value2) { throw null; }
        public static bool operator !=(System.Numerics.Matrix3x2 value1, System.Numerics.Matrix3x2 value2) { throw null; }
        public static System.Numerics.Matrix3x2 operator *(System.Numerics.Matrix3x2 value1, System.Numerics.Matrix3x2 value2) { throw null; }
        public static System.Numerics.Matrix3x2 operator *(System.Numerics.Matrix3x2 value1, float value2) { throw null; }
        public static System.Numerics.Matrix3x2 operator -(System.Numerics.Matrix3x2 value1, System.Numerics.Matrix3x2 value2) { throw null; }
        public static System.Numerics.Matrix3x2 operator -(System.Numerics.Matrix3x2 value) { throw null; }
        public static System.Numerics.Matrix3x2 Subtract(System.Numerics.Matrix3x2 value1, System.Numerics.Matrix3x2 value2) { throw null; }
        public override readonly string ToString() { throw null; }
        public readonly System.Numerics.Matrix3x2 WithElement(int row, int column, float value) { throw null; }
        public readonly System.Numerics.Matrix3x2 WithRow(int index, System.Numerics.Vector2 value) { throw null; }
    }
    public partial struct Matrix4x4 : System.IEquatable<System.Numerics.Matrix4x4>
    {
        public float M11;
        public float M12;
        public float M13;
        public float M14;
        public float M21;
        public float M22;
        public float M23;
        public float M24;
        public float M31;
        public float M32;
        public float M33;
        public float M34;
        public float M41;
        public float M42;
        public float M43;
        public float M44;
        public Matrix4x4(System.Numerics.Matrix3x2 value) { throw null; }
        public Matrix4x4(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44) { throw null; }
        public static System.Numerics.Matrix4x4 Identity { get { throw null; } }
        public readonly bool IsIdentity { get { throw null; } }
        public System.Numerics.Vector3 Translation { readonly get { throw null; } set { throw null; } }
        public System.Numerics.Vector4 X { readonly get { throw null; } set { throw null; } }
        public System.Numerics.Vector4 Y { readonly get { throw null; } set { throw null; } }
        public System.Numerics.Vector4 Z { readonly get { throw null; } set { throw null; } }
        public System.Numerics.Vector4 W { readonly get { throw null; } set { throw null; } }
        public System.Numerics.Vector4 this[int row] { readonly get { throw null; } set { throw null; } }
        public float this[int row, int column] { readonly get { throw null; } set { throw null; } }
        public static System.Numerics.Matrix4x4 Add(System.Numerics.Matrix4x4 value1, System.Numerics.Matrix4x4 value2) { throw null; }
        public static Matrix4x4 Create(float value) { throw null; }
        public static Matrix4x4 Create(System.Numerics.Matrix3x2 value) { throw null; }
        public static Matrix4x4 Create(System.Numerics.Vector4 value) { throw null; }
        public static Matrix4x4 Create(System.Numerics.Vector4 x, System.Numerics.Vector4 y, System.Numerics.Vector4 z, System.Numerics.Vector4 w) { throw null; }
        public static Matrix4x4 Create(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44) { throw null; }
        public static System.Numerics.Matrix4x4 CreateBillboard(System.Numerics.Vector3 objectPosition, System.Numerics.Vector3 cameraPosition, System.Numerics.Vector3 cameraUpVector, System.Numerics.Vector3 cameraForwardVector) { throw null; }
        public static System.Numerics.Matrix4x4 CreateBillboardLeftHanded(System.Numerics.Vector3 objectPosition, System.Numerics.Vector3 cameraPosition, System.Numerics.Vector3 cameraUpVector, System.Numerics.Vector3 cameraForwardVector) { throw null; }
        public static System.Numerics.Matrix4x4 CreateConstrainedBillboard(System.Numerics.Vector3 objectPosition, System.Numerics.Vector3 cameraPosition, System.Numerics.Vector3 rotateAxis, System.Numerics.Vector3 cameraForwardVector, System.Numerics.Vector3 objectForwardVector) { throw null; }
        public static System.Numerics.Matrix4x4 CreateConstrainedBillboardLeftHanded(System.Numerics.Vector3 objectPosition, System.Numerics.Vector3 cameraPosition, System.Numerics.Vector3 rotateAxis, System.Numerics.Vector3 cameraForwardVector, System.Numerics.Vector3 objectForwardVector) { throw null; }
        public static System.Numerics.Matrix4x4 CreateFromAxisAngle(System.Numerics.Vector3 axis, float angle) { throw null; }
        public static System.Numerics.Matrix4x4 CreateFromQuaternion(System.Numerics.Quaternion quaternion) { throw null; }
        public static System.Numerics.Matrix4x4 CreateFromYawPitchRoll(float yaw, float pitch, float roll) { throw null; }
        public static System.Numerics.Matrix4x4 CreateLookAt(System.Numerics.Vector3 cameraPosition, System.Numerics.Vector3 cameraTarget, System.Numerics.Vector3 cameraUpVector) { throw null; }
        public static System.Numerics.Matrix4x4 CreateLookAtLeftHanded(System.Numerics.Vector3 cameraPosition, System.Numerics.Vector3 cameraTarget, System.Numerics.Vector3 cameraUpVector) { throw null; }
        public static System.Numerics.Matrix4x4 CreateLookTo(System.Numerics.Vector3 cameraPosition, System.Numerics.Vector3 cameraDirection, System.Numerics.Vector3 cameraUpVector) { throw null; }
        public static System.Numerics.Matrix4x4 CreateLookToLeftHanded(System.Numerics.Vector3 cameraPosition, System.Numerics.Vector3 cameraDirection, System.Numerics.Vector3 cameraUpVector) { throw null; }
        public static System.Numerics.Matrix4x4 CreateOrthographic(float width, float height, float zNearPlane, float zFarPlane) { throw null; }
        public static System.Numerics.Matrix4x4 CreateOrthographicLeftHanded(float width, float height, float zNearPlane, float zFarPlane) { throw null; }
        public static System.Numerics.Matrix4x4 CreateOrthographicOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane) { throw null; }
        public static System.Numerics.Matrix4x4 CreateOrthographicOffCenterLeftHanded(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane) { throw null; }
        public static System.Numerics.Matrix4x4 CreatePerspective(float width, float height, float nearPlaneDistance, float farPlaneDistance) { throw null; }
        public static System.Numerics.Matrix4x4 CreatePerspectiveLeftHanded(float width, float height, float nearPlaneDistance, float farPlaneDistance) { throw null; }
        public static System.Numerics.Matrix4x4 CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance) { throw null; }
        public static System.Numerics.Matrix4x4 CreatePerspectiveFieldOfViewLeftHanded(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance) { throw null; }
        public static System.Numerics.Matrix4x4 CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance) { throw null; }
        public static System.Numerics.Matrix4x4 CreatePerspectiveOffCenterLeftHanded(float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance) { throw null; }
        public static System.Numerics.Matrix4x4 CreateReflection(System.Numerics.Plane value) { throw null; }
        public static System.Numerics.Matrix4x4 CreateRotationX(float radians) { throw null; }
        public static System.Numerics.Matrix4x4 CreateRotationX(float radians, System.Numerics.Vector3 centerPoint) { throw null; }
        public static System.Numerics.Matrix4x4 CreateRotationY(float radians) { throw null; }
        public static System.Numerics.Matrix4x4 CreateRotationY(float radians, System.Numerics.Vector3 centerPoint) { throw null; }
        public static System.Numerics.Matrix4x4 CreateRotationZ(float radians) { throw null; }
        public static System.Numerics.Matrix4x4 CreateRotationZ(float radians, System.Numerics.Vector3 centerPoint) { throw null; }
        public static System.Numerics.Matrix4x4 CreateScale(System.Numerics.Vector3 scales) { throw null; }
        public static System.Numerics.Matrix4x4 CreateScale(System.Numerics.Vector3 scales, System.Numerics.Vector3 centerPoint) { throw null; }
        public static System.Numerics.Matrix4x4 CreateScale(float scale) { throw null; }
        public static System.Numerics.Matrix4x4 CreateScale(float scale, System.Numerics.Vector3 centerPoint) { throw null; }
        public static System.Numerics.Matrix4x4 CreateScale(float xScale, float yScale, float zScale) { throw null; }
        public static System.Numerics.Matrix4x4 CreateScale(float xScale, float yScale, float zScale, System.Numerics.Vector3 centerPoint) { throw null; }
        public static System.Numerics.Matrix4x4 CreateShadow(System.Numerics.Vector3 lightDirection, System.Numerics.Plane plane) { throw null; }
        public static System.Numerics.Matrix4x4 CreateTranslation(System.Numerics.Vector3 position) { throw null; }
        public static System.Numerics.Matrix4x4 CreateTranslation(float xPosition, float yPosition, float zPosition) { throw null; }
        public static System.Numerics.Matrix4x4 CreateViewport(float x, float y, float width, float height, float minDepth, float maxDepth) { throw null; }
        public static System.Numerics.Matrix4x4 CreateViewportLeftHanded(float x, float y, float width, float height, float minDepth, float maxDepth) { throw null; }
        public static System.Numerics.Matrix4x4 CreateWorld(System.Numerics.Vector3 position, System.Numerics.Vector3 forward, System.Numerics.Vector3 up) { throw null; }
        public static bool Decompose(System.Numerics.Matrix4x4 matrix, out System.Numerics.Vector3 scale, out System.Numerics.Quaternion rotation, out System.Numerics.Vector3 translation) { throw null; }
        public readonly bool Equals(System.Numerics.Matrix4x4 other) { throw null; }
        public override readonly bool Equals([System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] object? obj) { throw null; }
        public readonly float GetDeterminant() { throw null; }
        public readonly float GetElement(int row, int column) { throw null; }
        public readonly System.Numerics.Vector4 GetRow(int index) { throw null; }
        public override readonly int GetHashCode() { throw null; }
        public static bool Invert(System.Numerics.Matrix4x4 matrix, out System.Numerics.Matrix4x4 result) { throw null; }
        public static System.Numerics.Matrix4x4 Lerp(System.Numerics.Matrix4x4 matrix1, System.Numerics.Matrix4x4 matrix2, float amount) { throw null; }
        public static System.Numerics.Matrix4x4 Multiply(System.Numerics.Matrix4x4 value1, System.Numerics.Matrix4x4 value2) { throw null; }
        public static System.Numerics.Matrix4x4 Multiply(System.Numerics.Matrix4x4 value1, float value2) { throw null; }
        public static System.Numerics.Matrix4x4 Negate(System.Numerics.Matrix4x4 value) { throw null; }
        public static System.Numerics.Matrix4x4 operator +(System.Numerics.Matrix4x4 value1, System.Numerics.Matrix4x4 value2) { throw null; }
        public static bool operator ==(System.Numerics.Matrix4x4 value1, System.Numerics.Matrix4x4 value2) { throw null; }
        public static bool operator !=(System.Numerics.Matrix4x4 value1, System.Numerics.Matrix4x4 value2) { throw null; }
        public static System.Numerics.Matrix4x4 operator *(System.Numerics.Matrix4x4 value1, System.Numerics.Matrix4x4 value2) { throw null; }
        public static System.Numerics.Matrix4x4 operator *(System.Numerics.Matrix4x4 value1, float value2) { throw null; }
        public static System.Numerics.Matrix4x4 operator -(System.Numerics.Matrix4x4 value1, System.Numerics.Matrix4x4 value2) { throw null; }
        public static System.Numerics.Matrix4x4 operator -(System.Numerics.Matrix4x4 value) { throw null; }
        public static System.Numerics.Matrix4x4 Subtract(System.Numerics.Matrix4x4 value1, System.Numerics.Matrix4x4 value2) { throw null; }
        public override readonly string ToString() { throw null; }
        public static System.Numerics.Matrix4x4 Transform(System.Numerics.Matrix4x4 value, System.Numerics.Quaternion rotation) { throw null; }
        public static System.Numerics.Matrix4x4 Transpose(System.Numerics.Matrix4x4 matrix) { throw null; }
        public readonly System.Numerics.Matrix4x4 WithElement(int row, int column, float value) { throw null; }
        public readonly System.Numerics.Matrix4x4 WithRow(int index, System.Numerics.Vector4 value) { throw null; }
    }
    public partial struct Plane : System.IEquatable<System.Numerics.Plane>
    {
        public System.Numerics.Vector3 Normal;
        public float D;
        public Plane(System.Numerics.Vector4 value) { throw null; }
        public Plane(System.Numerics.Vector3 normal, float d) { throw null; }
        public Plane(float x, float y, float z, float d) { throw null; }
        public static Plane Create(System.Numerics.Vector4 value) { throw null; }
        public static Plane Create(System.Numerics.Vector3 normal, float d) { throw null; }
        public static Plane Create(float x, float y, float z, float d) { throw null; }
        public static System.Numerics.Plane CreateFromVertices(System.Numerics.Vector3 point1, System.Numerics.Vector3 point2, System.Numerics.Vector3 point3) { throw null; }
        public static float Dot(System.Numerics.Plane plane, System.Numerics.Vector4 value) { throw null; }
        public static float DotCoordinate(System.Numerics.Plane plane, System.Numerics.Vector3 value) { throw null; }
        public static float DotNormal(System.Numerics.Plane plane, System.Numerics.Vector3 value) { throw null; }
        public readonly bool Equals(System.Numerics.Plane other) { throw null; }
        public override readonly bool Equals([System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] object? obj) { throw null; }
        public override readonly int GetHashCode() { throw null; }
        public static System.Numerics.Plane Normalize(System.Numerics.Plane value) { throw null; }
        public static bool operator ==(System.Numerics.Plane value1, System.Numerics.Plane value2) { throw null; }
        public static bool operator !=(System.Numerics.Plane value1, System.Numerics.Plane value2) { throw null; }
        public override readonly string ToString() { throw null; }
        public static System.Numerics.Plane Transform(System.Numerics.Plane plane, System.Numerics.Matrix4x4 matrix) { throw null; }
        public static System.Numerics.Plane Transform(System.Numerics.Plane plane, System.Numerics.Quaternion rotation) { throw null; }
    }
    public partial struct Quaternion : System.IEquatable<System.Numerics.Quaternion>
    {
        public float X;
        public float Y;
        public float Z;
        public float W;
        public Quaternion(System.Numerics.Vector3 vectorPart, float scalarPart) { throw null; }
        public Quaternion(float x, float y, float z, float w) { throw null; }
        public static System.Numerics.Quaternion Zero { get { throw null; } }
        public static System.Numerics.Quaternion Identity { get { throw null; } }
        public float this[int index] { readonly get { throw null; } set { throw null; } }
        public readonly bool IsIdentity { get { throw null; } }
        public static System.Numerics.Quaternion Add(System.Numerics.Quaternion value1, System.Numerics.Quaternion value2) { throw null; }
        public static System.Numerics.Quaternion Concatenate(System.Numerics.Quaternion value1, System.Numerics.Quaternion value2) { throw null; }
        public static System.Numerics.Quaternion Conjugate(System.Numerics.Quaternion value) { throw null; }
        public static System.Numerics.Quaternion Create(System.Numerics.Vector3 vectorPart, float scalarPart) { throw null; }
        public static System.Numerics.Quaternion Create(float x, float y, float z, float w) { throw null; }
        public static System.Numerics.Quaternion CreateFromAxisAngle(System.Numerics.Vector3 axis, float angle) { throw null; }
        public static System.Numerics.Quaternion CreateFromRotationMatrix(System.Numerics.Matrix4x4 matrix) { throw null; }
        public static System.Numerics.Quaternion CreateFromYawPitchRoll(float yaw, float pitch, float roll) { throw null; }
        public static System.Numerics.Quaternion Divide(System.Numerics.Quaternion value1, System.Numerics.Quaternion value2) { throw null; }
        public static float Dot(System.Numerics.Quaternion quaternion1, System.Numerics.Quaternion quaternion2) { throw null; }
        public readonly bool Equals(System.Numerics.Quaternion other) { throw null; }
        public override readonly bool Equals([System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] object? obj) { throw null; }
        public override readonly int GetHashCode() { throw null; }
        public static System.Numerics.Quaternion Inverse(System.Numerics.Quaternion value) { throw null; }
        public readonly float Length() { throw null; }
        public readonly float LengthSquared() { throw null; }
        public static System.Numerics.Quaternion Lerp(System.Numerics.Quaternion quaternion1, System.Numerics.Quaternion quaternion2, float amount) { throw null; }
        public static System.Numerics.Quaternion Multiply(System.Numerics.Quaternion value1, System.Numerics.Quaternion value2) { throw null; }
        public static System.Numerics.Quaternion Multiply(System.Numerics.Quaternion value1, float value2) { throw null; }
        public static System.Numerics.Quaternion Negate(System.Numerics.Quaternion value) { throw null; }
        public static System.Numerics.Quaternion Normalize(System.Numerics.Quaternion value) { throw null; }
        public static System.Numerics.Quaternion operator +(System.Numerics.Quaternion value1, System.Numerics.Quaternion value2) { throw null; }
        public static System.Numerics.Quaternion operator /(System.Numerics.Quaternion value1, System.Numerics.Quaternion value2) { throw null; }
        public static bool operator ==(System.Numerics.Quaternion value1, System.Numerics.Quaternion value2) { throw null; }
        public static bool operator !=(System.Numerics.Quaternion value1, System.Numerics.Quaternion value2) { throw null; }
        public static System.Numerics.Quaternion operator *(System.Numerics.Quaternion value1, System.Numerics.Quaternion value2) { throw null; }
        public static System.Numerics.Quaternion operator *(System.Numerics.Quaternion value1, float value2) { throw null; }
        public static System.Numerics.Quaternion operator -(System.Numerics.Quaternion value1, System.Numerics.Quaternion value2) { throw null; }
        public static System.Numerics.Quaternion operator -(System.Numerics.Quaternion value) { throw null; }
        public static System.Numerics.Quaternion Slerp(System.Numerics.Quaternion quaternion1, System.Numerics.Quaternion quaternion2, float amount) { throw null; }
        public static System.Numerics.Quaternion Subtract(System.Numerics.Quaternion value1, System.Numerics.Quaternion value2) { throw null; }
        public override readonly string ToString() { throw null; }
    }
    public static partial class Vector
    {
        public static bool IsHardwareAccelerated { get { throw null; } }
        public static System.Numerics.Vector<T> Abs<T>(System.Numerics.Vector<T> value) { throw null; }
        public static System.Numerics.Vector<T> Add<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> AddSaturate<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static bool All<T>(System.Numerics.Vector<T> vector, T value) { throw null; }
        public static bool AllWhereAllBitsSet<T>(System.Numerics.Vector<T> vector) { throw null; }
        public static System.Numerics.Vector<T> AndNot<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static bool Any<T>(System.Numerics.Vector<T> vector, T value) { throw null; }
        public static bool AnyWhereAllBitsSet<T>(System.Numerics.Vector<T> vector) { throw null; }
        public static System.Numerics.Vector<TTo> As<TFrom, TTo>(this System.Numerics.Vector<TFrom> vector) { throw null; }
        public static System.Numerics.Plane AsPlane(this System.Numerics.Vector4 value) { throw null; }
        public static System.Numerics.Quaternion AsQuaternion(this System.Numerics.Vector4 value) { throw null; }
        public static System.Numerics.Vector2 AsVector2(this System.Numerics.Vector3 value) { throw null; }
        public static System.Numerics.Vector2 AsVector2(this System.Numerics.Vector4 value) { throw null; }
        public static System.Numerics.Vector3 AsVector3(this System.Numerics.Vector2 value) { throw null; }
        public static System.Numerics.Vector3 AsVector3(this System.Numerics.Vector4 value) { throw null; }
        public static System.Numerics.Vector3 AsVector3Unsafe(this System.Numerics.Vector2 value) { throw null; }
        public static System.Numerics.Vector4 AsVector4(this System.Numerics.Plane value) { throw null; }
        public static System.Numerics.Vector4 AsVector4(this System.Numerics.Quaternion value) { throw null; }
        public static System.Numerics.Vector4 AsVector4(this System.Numerics.Vector2 value) { throw null; }
        public static System.Numerics.Vector4 AsVector4(this System.Numerics.Vector3 value) { throw null; }
        public static System.Numerics.Vector4 AsVector4Unsafe(this System.Numerics.Vector2 value) { throw null; }
        public static System.Numerics.Vector4 AsVector4Unsafe(this System.Numerics.Vector3 value) { throw null; }
        public static System.Numerics.Vector<System.Byte> AsVectorByte<T>(System.Numerics.Vector<T> value) { throw null; }
        public static System.Numerics.Vector<System.Double> AsVectorDouble<T>(System.Numerics.Vector<T> value) { throw null; }
        public static System.Numerics.Vector<System.Int16> AsVectorInt16<T>(System.Numerics.Vector<T> value) { throw null; }
        public static System.Numerics.Vector<System.Int32> AsVectorInt32<T>(System.Numerics.Vector<T> value) { throw null; }
        public static System.Numerics.Vector<System.Int64> AsVectorInt64<T>(System.Numerics.Vector<T> value) { throw null; }
        public static System.Numerics.Vector<nint> AsVectorNInt<T>(System.Numerics.Vector<T> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<nuint> AsVectorNUInt<T>(System.Numerics.Vector<T> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.SByte> AsVectorSByte<T>(System.Numerics.Vector<T> value) { throw null; }
        public static System.Numerics.Vector<System.Single> AsVectorSingle<T>(System.Numerics.Vector<T> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.UInt16> AsVectorUInt16<T>(System.Numerics.Vector<T> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.UInt32> AsVectorUInt32<T>(System.Numerics.Vector<T> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.UInt64> AsVectorUInt64<T>(System.Numerics.Vector<T> value) { throw null; }
        public static System.Numerics.Vector<T> BitwiseAnd<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> BitwiseOr<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<System.Double> Ceiling(System.Numerics.Vector<System.Double> value) { throw null; }
        public static System.Numerics.Vector<System.Single> Ceiling(System.Numerics.Vector<System.Single> value) { throw null; }
        public static System.Numerics.Vector<T> Clamp<T>(System.Numerics.Vector<T> value, System.Numerics.Vector<T> min, System.Numerics.Vector<T> max) { throw null; }
        public static System.Numerics.Vector<T> ClampNative<T>(System.Numerics.Vector<T> value, System.Numerics.Vector<T> min, System.Numerics.Vector<T> max) { throw null; }
        public static System.Numerics.Vector<System.Single> ConditionalSelect(System.Numerics.Vector<System.Int32> condition, System.Numerics.Vector<System.Single> left, System.Numerics.Vector<System.Single> right) { throw null; }
        public static System.Numerics.Vector<System.Double> ConditionalSelect(System.Numerics.Vector<System.Int64> condition, System.Numerics.Vector<System.Double> left, System.Numerics.Vector<System.Double> right) { throw null; }
        public static System.Numerics.Vector<T> ConditionalSelect<T>(System.Numerics.Vector<T> condition, System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<System.Double> ConvertToDouble(System.Numerics.Vector<System.Int64> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.Double> ConvertToDouble(System.Numerics.Vector<System.UInt64> value) { throw null; }
        public static System.Numerics.Vector<System.Int32> ConvertToInt32(System.Numerics.Vector<System.Single> value) { throw null; }
        public static System.Numerics.Vector<System.Int32> ConvertToInt32Native(System.Numerics.Vector<System.Single> value) { throw null; }
        public static System.Numerics.Vector<System.Int64> ConvertToInt64(System.Numerics.Vector<System.Double> value) { throw null; }
        public static System.Numerics.Vector<System.Int64> ConvertToInt64Native(System.Numerics.Vector<System.Double> value) { throw null; }
        public static System.Numerics.Vector<System.Single> ConvertToSingle(System.Numerics.Vector<System.Int32> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.Single> ConvertToSingle(System.Numerics.Vector<System.UInt32> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.UInt32> ConvertToUInt32(System.Numerics.Vector<System.Single> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.UInt32> ConvertToUInt32Native(System.Numerics.Vector<System.Single> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.UInt64> ConvertToUInt64(System.Numerics.Vector<System.Double> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.UInt64> ConvertToUInt64Native(System.Numerics.Vector<System.Double> value) { throw null; }
        public static System.Numerics.Vector<T> CopySign<T>(System.Numerics.Vector<T> value, System.Numerics.Vector<T> sign) { throw null; }
        public static System.Numerics.Vector<double> Cos(System.Numerics.Vector<double> vector) { throw null; }
        public static System.Numerics.Vector<float> Cos(System.Numerics.Vector<float> vector) { throw null; }
        public static int Count<T>(System.Numerics.Vector<T> vector, T value) { throw null; }
        public static int CountWhereAllBitsSet<T>(System.Numerics.Vector<T> vector) { throw null; }
        public static System.Numerics.Vector<T> Create<T>(T value) { throw null; }
        public static System.Numerics.Vector<T> Create<T>(System.ReadOnlySpan<T> values) { throw null; }
        public static System.Numerics.Vector<T> CreateScalar<T>(T value) { throw null; }
        public static System.Numerics.Vector<T> CreateScalarUnsafe<T>(T value) { throw null; }
        public static System.Numerics.Vector<T> CreateSequence<T>(T start, T step) { throw null; }
        public static System.Numerics.Vector<double> DegreesToRadians(System.Numerics.Vector<double> degrees) { throw null; }
        public static System.Numerics.Vector<float> DegreesToRadians(System.Numerics.Vector<float> degrees) { throw null; }
        public static System.Numerics.Vector<T> Divide<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> Divide<T>(System.Numerics.Vector<T> left, T right) { throw null; }
        public static T Dot<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<System.Int64> Equals(System.Numerics.Vector<System.Double> left, System.Numerics.Vector<System.Double> right) { throw null; }
        public static System.Numerics.Vector<System.Int32> Equals(System.Numerics.Vector<System.Int32> left, System.Numerics.Vector<System.Int32> right) { throw null; }
        public static System.Numerics.Vector<System.Int64> Equals(System.Numerics.Vector<System.Int64> left, System.Numerics.Vector<System.Int64> right) { throw null; }
        public static System.Numerics.Vector<System.Int32> Equals(System.Numerics.Vector<System.Single> left, System.Numerics.Vector<System.Single> right) { throw null; }
        public static bool EqualsAll<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static bool EqualsAny<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> Equals<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<double> Exp(System.Numerics.Vector<double> vector) { throw null; }
        public static System.Numerics.Vector<float> Exp(System.Numerics.Vector<float> vector) { throw null; }
        [CLSCompliant(false)]
        public static uint ExtractMostSignificantBits(this System.Numerics.Vector2 vector) { throw null; }
        [CLSCompliant(false)]
        public static uint ExtractMostSignificantBits(this System.Numerics.Vector3 vector) { throw null; }
        [CLSCompliant(false)]
        public static uint ExtractMostSignificantBits(this System.Numerics.Vector4 vector) { throw null; }
        public static System.Numerics.Vector<System.Double> Floor(System.Numerics.Vector<System.Double> value) { throw null; }
        public static System.Numerics.Vector<System.Single> Floor(System.Numerics.Vector<System.Single> value) { throw null; }
        public static System.Numerics.Vector<double> FusedMultiplyAdd(System.Numerics.Vector<double> left, System.Numerics.Vector<double> right, System.Numerics.Vector<double> addend) { throw null; }
        public static System.Numerics.Vector<float> FusedMultiplyAdd(System.Numerics.Vector<float> left, System.Numerics.Vector<float> right, System.Numerics.Vector<float> addend) { throw null; }
        public static T GetElement<T>(this System.Numerics.Vector<T> vector, int index) { throw null; }
        public static float GetElement(this System.Numerics.Vector2 vector, int index) { throw null; }
        public static float GetElement(this System.Numerics.Vector3 vector, int index) { throw null; }
        public static float GetElement(this System.Numerics.Vector4 vector, int index) { throw null; }
        public static System.Numerics.Vector<System.Int64> GreaterThan(System.Numerics.Vector<System.Double> left, System.Numerics.Vector<System.Double> right) { throw null; }
        public static System.Numerics.Vector<System.Int32> GreaterThan(System.Numerics.Vector<System.Int32> left, System.Numerics.Vector<System.Int32> right) { throw null; }
        public static System.Numerics.Vector<System.Int64> GreaterThan(System.Numerics.Vector<System.Int64> left, System.Numerics.Vector<System.Int64> right) { throw null; }
        public static System.Numerics.Vector<System.Int32> GreaterThan(System.Numerics.Vector<System.Single> left, System.Numerics.Vector<System.Single> right) { throw null; }
        public static bool GreaterThanAll<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static bool GreaterThanAny<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<System.Int64> GreaterThanOrEqual(System.Numerics.Vector<System.Double> left, System.Numerics.Vector<System.Double> right) { throw null; }
        public static System.Numerics.Vector<System.Int32> GreaterThanOrEqual(System.Numerics.Vector<System.Int32> left, System.Numerics.Vector<System.Int32> right) { throw null; }
        public static System.Numerics.Vector<System.Int64> GreaterThanOrEqual(System.Numerics.Vector<System.Int64> left, System.Numerics.Vector<System.Int64> right) { throw null; }
        public static System.Numerics.Vector<System.Int32> GreaterThanOrEqual(System.Numerics.Vector<System.Single> left, System.Numerics.Vector<System.Single> right) { throw null; }
        public static bool GreaterThanOrEqualAll<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static bool GreaterThanOrEqualAny<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> GreaterThanOrEqual<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> GreaterThan<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<double> Hypot(System.Numerics.Vector<double> x, System.Numerics.Vector<double> y) { throw null; }
        public static System.Numerics.Vector<float> Hypot(System.Numerics.Vector<float> x, System.Numerics.Vector<float> y) { throw null; }
        public static int IndexOf<T>(System.Numerics.Vector<T> vector, T value) { throw null; }
        public static int IndexOfWhereAllBitsSet<T>(System.Numerics.Vector<T> vector) { throw null; }
        public static System.Numerics.Vector<T> IsEvenInteger<T>(System.Numerics.Vector<T> vector) { throw null; }
        public static System.Numerics.Vector<T> IsFinite<T>(System.Numerics.Vector<T> vector) { throw null; }
        public static System.Numerics.Vector<T> IsInfinity<T>(System.Numerics.Vector<T> vector) { throw null; }
        public static System.Numerics.Vector<T> IsInteger<T>(System.Numerics.Vector<T> vector) { throw null; }
        public static System.Numerics.Vector<T> IsNaN<T>(System.Numerics.Vector<T> vector) { throw null; }
        public static System.Numerics.Vector<T> IsNegative<T>(System.Numerics.Vector<T> vector) { throw null; }
        public static System.Numerics.Vector<T> IsNegativeInfinity<T>(System.Numerics.Vector<T> vector) { throw null; }
        public static System.Numerics.Vector<T> IsNormal<T>(System.Numerics.Vector<T> vector) { throw null; }
        public static System.Numerics.Vector<T> IsOddInteger<T>(System.Numerics.Vector<T> vector) { throw null; }
        public static System.Numerics.Vector<T> IsPositive<T>(System.Numerics.Vector<T> vector) { throw null; }
        public static System.Numerics.Vector<T> IsPositiveInfinity<T>(System.Numerics.Vector<T> vector) { throw null; }
        public static System.Numerics.Vector<T> IsSubnormal<T>(System.Numerics.Vector<T> vector) { throw null; }
        public static System.Numerics.Vector<T> IsZero<T>(System.Numerics.Vector<T> vector) { throw null; }
        public static int LastIndexOf<T>(System.Numerics.Vector<T> vector, T value) { throw null; }
        public static int LastIndexOfWhereAllBitsSet<T>(System.Numerics.Vector<T> vector) { throw null; }
        public static System.Numerics.Vector<double> Lerp(System.Numerics.Vector<double> x, System.Numerics.Vector<double> y, System.Numerics.Vector<double> amount) { throw null; }
        public static System.Numerics.Vector<float> Lerp(System.Numerics.Vector<float> x, System.Numerics.Vector<float> y, System.Numerics.Vector<float> amount) { throw null; }
        public static System.Numerics.Vector<System.Int64> LessThan(System.Numerics.Vector<System.Double> left, System.Numerics.Vector<System.Double> right) { throw null; }
        public static System.Numerics.Vector<System.Int32> LessThan(System.Numerics.Vector<System.Int32> left, System.Numerics.Vector<System.Int32> right) { throw null; }
        public static System.Numerics.Vector<System.Int64> LessThan(System.Numerics.Vector<System.Int64> left, System.Numerics.Vector<System.Int64> right) { throw null; }
        public static System.Numerics.Vector<System.Int32> LessThan(System.Numerics.Vector<System.Single> left, System.Numerics.Vector<System.Single> right) { throw null; }
        public static bool LessThanAll<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static bool LessThanAny<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<System.Int64> LessThanOrEqual(System.Numerics.Vector<System.Double> left, System.Numerics.Vector<System.Double> right) { throw null; }
        public static System.Numerics.Vector<System.Int32> LessThanOrEqual(System.Numerics.Vector<System.Int32> left, System.Numerics.Vector<System.Int32> right) { throw null; }
        public static System.Numerics.Vector<System.Int64> LessThanOrEqual(System.Numerics.Vector<System.Int64> left, System.Numerics.Vector<System.Int64> right) { throw null; }
        public static System.Numerics.Vector<System.Int32> LessThanOrEqual(System.Numerics.Vector<System.Single> left, System.Numerics.Vector<System.Single> right) { throw null; }
        public static bool LessThanOrEqualAll<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static bool LessThanOrEqualAny<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> LessThanOrEqual<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> LessThan<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static unsafe System.Numerics.Vector<T> Load<T>(T* source) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static unsafe System.Numerics.Vector<T> LoadAligned<T>(T* source) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static unsafe System.Numerics.Vector<T> LoadAlignedNonTemporal<T>(T* source) { throw null; }
        public static System.Numerics.Vector<T> LoadUnsafe<T>(ref readonly T source) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<T> LoadUnsafe<T>(ref readonly T source, nuint elementOffset) { throw null; }
        public static System.Numerics.Vector<double> Log(System.Numerics.Vector<double> vector) { throw null; }
        public static System.Numerics.Vector<float> Log(System.Numerics.Vector<float> vector) { throw null; }
        public static System.Numerics.Vector<double> Log2(System.Numerics.Vector<double> vector) { throw null; }
        public static System.Numerics.Vector<float> Log2(System.Numerics.Vector<float> vector) { throw null; }
        public static System.Numerics.Vector<T> Max<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> MaxMagnitude<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> MaxMagnitudeNumber<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> MaxNative<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> MaxNumber<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> Min<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> MinMagnitude<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> MinMagnitudeNumber<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> MinNative<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> MinNumber<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> Multiply<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> Multiply<T>(System.Numerics.Vector<T> left, T right) { throw null; }
        public static System.Numerics.Vector<T> Multiply<T>(T left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<double> MultiplyAddEstimate(System.Numerics.Vector<double> left, System.Numerics.Vector<double> right, System.Numerics.Vector<double> addend) { throw null; }
        public static System.Numerics.Vector<float> MultiplyAddEstimate(System.Numerics.Vector<float> left, System.Numerics.Vector<float> right, System.Numerics.Vector<float> addend) { throw null; }
        public static System.Numerics.Vector<System.Single> Narrow(System.Numerics.Vector<System.Double> low, System.Numerics.Vector<System.Double> high) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.SByte> Narrow(System.Numerics.Vector<System.Int16> low, System.Numerics.Vector<System.Int16> high) { throw null; }
        public static System.Numerics.Vector<System.Int16> Narrow(System.Numerics.Vector<System.Int32> low, System.Numerics.Vector<System.Int32> high) { throw null; }
        public static System.Numerics.Vector<System.Int32> Narrow(System.Numerics.Vector<System.Int64> low, System.Numerics.Vector<System.Int64> high) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.Byte> Narrow(System.Numerics.Vector<System.UInt16> low, System.Numerics.Vector<System.UInt16> high) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.UInt16> Narrow(System.Numerics.Vector<System.UInt32> low, System.Numerics.Vector<System.UInt32> high) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.UInt32> Narrow(System.Numerics.Vector<System.UInt64> low, System.Numerics.Vector<System.UInt64> high) { throw null; }
        public static System.Numerics.Vector<System.Single> NarrowWithSaturation(System.Numerics.Vector<System.Double> low, System.Numerics.Vector<System.Double> high) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.SByte> NarrowWithSaturation(System.Numerics.Vector<System.Int16> low, System.Numerics.Vector<System.Int16> high) { throw null; }
        public static System.Numerics.Vector<System.Int16> NarrowWithSaturation(System.Numerics.Vector<System.Int32> low, System.Numerics.Vector<System.Int32> high) { throw null; }
        public static System.Numerics.Vector<System.Int32> NarrowWithSaturation(System.Numerics.Vector<System.Int64> low, System.Numerics.Vector<System.Int64> high) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.Byte> NarrowWithSaturation(System.Numerics.Vector<System.UInt16> low, System.Numerics.Vector<System.UInt16> high) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.UInt16> NarrowWithSaturation(System.Numerics.Vector<System.UInt32> low, System.Numerics.Vector<System.UInt32> high) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.UInt32> NarrowWithSaturation(System.Numerics.Vector<System.UInt64> low, System.Numerics.Vector<System.UInt64> high) { throw null; }
        public static System.Numerics.Vector<T> Negate<T>(System.Numerics.Vector<T> value) { throw null; }
        public static bool None<T>(System.Numerics.Vector<T> vector, T value) { throw null; }
        public static bool NoneWhereAllBitsSet<T>(System.Numerics.Vector<T> vector) { throw null; }
        public static System.Numerics.Vector<T> OnesComplement<T>(System.Numerics.Vector<T> value) { throw null; }
        public static System.Numerics.Vector<double> RadiansToDegrees(System.Numerics.Vector<double> radians) { throw null; }
        public static System.Numerics.Vector<float> RadiansToDegrees(System.Numerics.Vector<float> radians) { throw null; }
        public static System.Numerics.Vector<double> Round(System.Numerics.Vector<double> vector) { throw null; }
        public static System.Numerics.Vector<float> Round(System.Numerics.Vector<float> vector) { throw null; }
        public static System.Numerics.Vector<double> Round(System.Numerics.Vector<double> vector, System.MidpointRounding mode) { throw null; }
        public static System.Numerics.Vector<float> Round(System.Numerics.Vector<float> vector, System.MidpointRounding mode) { throw null; }
        public static System.Numerics.Vector<System.Byte> ShiftLeft(System.Numerics.Vector<System.Byte> value, int shiftCount) { throw null; }
        public static System.Numerics.Vector<System.Int16> ShiftLeft(System.Numerics.Vector<System.Int16> value, int shiftCount) { throw null; }
        public static System.Numerics.Vector<System.Int32> ShiftLeft(System.Numerics.Vector<System.Int32> value, int shiftCount) { throw null; }
        public static System.Numerics.Vector<System.Int64> ShiftLeft(System.Numerics.Vector<System.Int64> value, int shiftCount) { throw null; }
        public static System.Numerics.Vector<nint> ShiftLeft(System.Numerics.Vector<nint> value, int shiftCount) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<nuint> ShiftLeft(System.Numerics.Vector<nuint> value, int shiftCount) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.SByte> ShiftLeft(System.Numerics.Vector<System.SByte> value, int shiftCount) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.UInt16> ShiftLeft(System.Numerics.Vector<System.UInt16> value, int shiftCount) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.UInt32> ShiftLeft(System.Numerics.Vector<System.UInt32> value, int shiftCount) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.UInt64> ShiftLeft(System.Numerics.Vector<System.UInt64> value, int shiftCount) { throw null; }
        public static System.Numerics.Vector<System.Int16> ShiftRightArithmetic(System.Numerics.Vector<System.Int16> value, int shiftCount) { throw null; }
        public static System.Numerics.Vector<System.Int32> ShiftRightArithmetic(System.Numerics.Vector<System.Int32> value, int shiftCount) { throw null; }
        public static System.Numerics.Vector<System.Int64> ShiftRightArithmetic(System.Numerics.Vector<System.Int64> value, int shiftCount) { throw null; }
        public static System.Numerics.Vector<nint> ShiftRightArithmetic(System.Numerics.Vector<nint> value, int shiftCount) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.SByte> ShiftRightArithmetic(System.Numerics.Vector<System.SByte> value, int shiftCount) { throw null; }
        public static System.Numerics.Vector<System.Byte> ShiftRightLogical(System.Numerics.Vector<System.Byte> value, int shiftCount) { throw null; }
        public static System.Numerics.Vector<System.Int16> ShiftRightLogical(System.Numerics.Vector<System.Int16> value, int shiftCount) { throw null; }
        public static System.Numerics.Vector<System.Int32> ShiftRightLogical(System.Numerics.Vector<System.Int32> value, int shiftCount) { throw null; }
        public static System.Numerics.Vector<System.Int64> ShiftRightLogical(System.Numerics.Vector<System.Int64> value, int shiftCount) { throw null; }
        public static System.Numerics.Vector<nint> ShiftRightLogical(System.Numerics.Vector<nint> value, int shiftCount) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<nuint> ShiftRightLogical(System.Numerics.Vector<nuint> value, int shiftCount) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.SByte> ShiftRightLogical(System.Numerics.Vector<System.SByte> value, int shiftCount) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.UInt16> ShiftRightLogical(System.Numerics.Vector<System.UInt16> value, int shiftCount) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.UInt32> ShiftRightLogical(System.Numerics.Vector<System.UInt32> value, int shiftCount) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<System.UInt64> ShiftRightLogical(System.Numerics.Vector<System.UInt64> value, int shiftCount) { throw null; }
        public static System.Numerics.Vector<double> Sin(System.Numerics.Vector<double> vector) { throw null; }
        public static System.Numerics.Vector<float> Sin(System.Numerics.Vector<float> vector) { throw null; }
        public static (System.Numerics.Vector<double> Sin, System.Numerics.Vector<double> Cos) SinCos(System.Numerics.Vector<double> vector) { throw null; }
        public static (System.Numerics.Vector<float> Sin, System.Numerics.Vector<float> Cos) SinCos(System.Numerics.Vector<float> vector) { throw null; }
        public static System.Numerics.Vector<T> SquareRoot<T>(System.Numerics.Vector<T> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static unsafe void Store<T>(this System.Numerics.Vector<T> source, T* destination) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static unsafe void Store(this System.Numerics.Vector2 source, float* destination) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static unsafe void Store(this System.Numerics.Vector3 source, float* destination) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static unsafe void Store(this System.Numerics.Vector4 source, float* destination) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static unsafe void StoreAligned<T>(this System.Numerics.Vector<T> source, T* destination) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static unsafe void StoreAligned(this System.Numerics.Vector2 source, float* destination) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static unsafe void StoreAligned(this System.Numerics.Vector3 source, float* destination) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static unsafe void StoreAligned(this System.Numerics.Vector4 source, float* destination) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static unsafe void StoreAlignedNonTemporal<T>(this System.Numerics.Vector<T> source, T* destination) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static unsafe void StoreAlignedNonTemporal(this System.Numerics.Vector2 source, float* destination) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static unsafe void StoreAlignedNonTemporal(this System.Numerics.Vector3 source, float* destination) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static unsafe void StoreAlignedNonTemporal(this System.Numerics.Vector4 source, float* destination) { throw null; }
        public static void StoreUnsafe<T>(this System.Numerics.Vector<T> source, ref T destination) { throw null; }
        public static void StoreUnsafe(this System.Numerics.Vector2 source, ref float destination) { throw null; }
        public static void StoreUnsafe(this System.Numerics.Vector3 source, ref float destination) { throw null; }
        public static void StoreUnsafe(this System.Numerics.Vector4 source, ref float destination) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static void StoreUnsafe<T>(this System.Numerics.Vector<T> source, ref T destination, nuint elementOffset) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static void StoreUnsafe(this System.Numerics.Vector2 source, ref float destination, nuint elementOffset) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static void StoreUnsafe(this System.Numerics.Vector3 source, ref float destination, nuint elementOffset) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static void StoreUnsafe(this System.Numerics.Vector4 source, ref float destination, nuint elementOffset) { throw null; }
        public static System.Numerics.Vector<T> Subtract<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> SubtractSaturate<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static T Sum<T>(System.Numerics.Vector<T> value) { throw null; }
        public static T ToScalar<T>(this System.Numerics.Vector<T> vector) { throw null; }
        public static float ToScalar(this System.Numerics.Vector2 vector) { throw null; }
        public static float ToScalar(this System.Numerics.Vector3 vector) { throw null; }
        public static float ToScalar(this System.Numerics.Vector4 vector) { throw null; }
        public static System.Numerics.Vector<double> Truncate(System.Numerics.Vector<double> vector) { throw null; }
        public static System.Numerics.Vector<float> Truncate(System.Numerics.Vector<float> vector) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static void Widen(System.Numerics.Vector<System.Byte> source, out System.Numerics.Vector<System.UInt16> low, out System.Numerics.Vector<System.UInt16> high) { throw null; }
        public static void Widen(System.Numerics.Vector<System.Int16> source, out System.Numerics.Vector<System.Int32> low, out System.Numerics.Vector<System.Int32> high) { throw null; }
        public static void Widen(System.Numerics.Vector<System.Int32> source, out System.Numerics.Vector<System.Int64> low, out System.Numerics.Vector<System.Int64> high) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static void Widen(System.Numerics.Vector<System.SByte> source, out System.Numerics.Vector<System.Int16> low, out System.Numerics.Vector<System.Int16> high) { throw null; }
        public static void Widen(System.Numerics.Vector<System.Single> source, out System.Numerics.Vector<System.Double> low, out System.Numerics.Vector<System.Double> high) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static void Widen(System.Numerics.Vector<System.UInt16> source, out System.Numerics.Vector<System.UInt32> low, out System.Numerics.Vector<System.UInt32> high) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static void Widen(System.Numerics.Vector<System.UInt32> source, out System.Numerics.Vector<System.UInt64> low, out System.Numerics.Vector<System.UInt64> high) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<ushort> WidenLower(System.Numerics.Vector<System.Byte> source) { throw null; }
        public static System.Numerics.Vector<int> WidenLower(System.Numerics.Vector<System.Int16> source) { throw null; }
        public static System.Numerics.Vector<long> WidenLower(System.Numerics.Vector<System.Int32> source) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<short> WidenLower(System.Numerics.Vector<System.SByte> source) { throw null; }
        public static System.Numerics.Vector<double> WidenLower(System.Numerics.Vector<System.Single> source) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<uint> WidenLower(System.Numerics.Vector<System.UInt16> source) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<ulong> WidenLower(System.Numerics.Vector<System.UInt32> source) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<ushort> WidenUpper(System.Numerics.Vector<System.Byte> source) { throw null; }
        public static System.Numerics.Vector<int> WidenUpper(System.Numerics.Vector<System.Int16> source) { throw null; }
        public static System.Numerics.Vector<long> WidenUpper(System.Numerics.Vector<System.Int32> source) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<short> WidenUpper(System.Numerics.Vector<System.SByte> source) { throw null; }
        public static System.Numerics.Vector<double> WidenUpper(System.Numerics.Vector<System.Single> source) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<uint> WidenUpper(System.Numerics.Vector<System.UInt16> source) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static System.Numerics.Vector<ulong> WidenUpper(System.Numerics.Vector<System.UInt32> source) { throw null; }
        public static System.Numerics.Vector<T> WithElement<T>(this System.Numerics.Vector<T> vector, int index, T value) { throw null; }
        public static System.Numerics.Vector2 WithElement(this System.Numerics.Vector2 vector, int index, float value) { throw null; }
        public static System.Numerics.Vector3 WithElement(this System.Numerics.Vector3 vector, int index, float value) { throw null; }
        public static System.Numerics.Vector4 WithElement(this System.Numerics.Vector4 vector, int index, float value) { throw null; }
        public static System.Numerics.Vector<T> Xor<T>(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
    }
    public partial struct Vector2 : System.IEquatable<System.Numerics.Vector2>, System.IFormattable
    {
        public float X;
        public float Y;
        public Vector2(float value) { throw null; }
        public Vector2(float x, float y) { throw null; }
        public Vector2(System.ReadOnlySpan<float> values) { throw null; }
        public static System.Numerics.Vector2 AllBitsSet { get { throw null; } }
        public static System.Numerics.Vector2 E { get { throw null; } }
        public static System.Numerics.Vector2 Epsilon { get { throw null; } }
        public static System.Numerics.Vector2 NaN { get { throw null; } }
        public static System.Numerics.Vector2 NegativeInfinity { get { throw null; } }
        public static System.Numerics.Vector2 NegativeZero { get { throw null; } }
        public static System.Numerics.Vector2 One { get { throw null; } }
        public static System.Numerics.Vector2 Pi { get { throw null; } }
        public static System.Numerics.Vector2 PositiveInfinity { get { throw null; } }
        public static System.Numerics.Vector2 Tau { get { throw null; } }
        public static System.Numerics.Vector2 UnitX { get { throw null; } }
        public static System.Numerics.Vector2 UnitY { get { throw null; } }
        public float this[int index] { readonly get { throw null; } set { throw null; } }
        public static System.Numerics.Vector2 Zero { get { throw null; } }
        public static System.Numerics.Vector2 Abs(System.Numerics.Vector2 value) { throw null; }
        public static System.Numerics.Vector2 Add(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static bool All(System.Numerics.Vector2 vector, float value) { throw null; }
        public static bool AllWhereAllBitsSet(System.Numerics.Vector2 vector) { throw null; }
        public static System.Numerics.Vector2 AndNot(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static bool Any(System.Numerics.Vector2 vector, float value) { throw null; }
        public static bool AnyWhereAllBitsSet(System.Numerics.Vector2 vector) { throw null; }
        public static System.Numerics.Vector2 BitwiseAnd(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static System.Numerics.Vector2 BitwiseOr(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static System.Numerics.Vector2 Clamp(System.Numerics.Vector2 value1, System.Numerics.Vector2 min, System.Numerics.Vector2 max) { throw null; }
        public static System.Numerics.Vector2 ClampNative(System.Numerics.Vector2 value1, System.Numerics.Vector2 min, System.Numerics.Vector2 max) { throw null; }
        public static System.Numerics.Vector2 ConditionalSelect(System.Numerics.Vector2 condition, System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static System.Numerics.Vector2 CopySign(System.Numerics.Vector2 value, System.Numerics.Vector2 sign) { throw null; }
        public static int Count(System.Numerics.Vector2 vector, float value) { throw null; }
        public static int CountWhereAllBitsSet(System.Numerics.Vector2 vector) { throw null; }
        public readonly void CopyTo(float[] array) { }
        public readonly void CopyTo(float[] array, int index) { }
        public readonly void CopyTo(System.Span<float> destination) { }
        public static System.Numerics.Vector2 Cos(System.Numerics.Vector2 vector) { throw null; }
        public static System.Numerics.Vector2 Create(float value) { throw null; }
        public static System.Numerics.Vector2 Create(float x, float y) { throw null; }
        public static System.Numerics.Vector2 Create(System.ReadOnlySpan<float> values) { throw null; }
        public static System.Numerics.Vector2 CreateScalar(float x) { throw null; }
        public static System.Numerics.Vector2 CreateScalarUnsafe(float x) { throw null; }
        public readonly bool TryCopyTo(System.Span<float> destination) { throw null; }
        public static System.Numerics.Vector2 DegreesToRadians(System.Numerics.Vector2 degrees) { throw null; }
        public static float Distance(System.Numerics.Vector2 value1, System.Numerics.Vector2 value2) { throw null; }
        public static float DistanceSquared(System.Numerics.Vector2 value1, System.Numerics.Vector2 value2) { throw null; }
        public static System.Numerics.Vector2 Divide(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static System.Numerics.Vector2 Divide(System.Numerics.Vector2 left, float divisor) { throw null; }
        public static float Dot(System.Numerics.Vector2 value1, System.Numerics.Vector2 value2) { throw null; }
        public static float Cross(System.Numerics.Vector2 value1, System.Numerics.Vector2 value2) { throw null; }
        public readonly bool Equals(System.Numerics.Vector2 other) { throw null; }
        public override readonly bool Equals([System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] object? obj) { throw null; }
        public static Vector2 Equals(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static bool EqualsAll(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static bool EqualsAny(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static System.Numerics.Vector2 Exp(System.Numerics.Vector2 vector) { throw null; }
        public static System.Numerics.Vector2 FusedMultiplyAdd(System.Numerics.Vector2 left, System.Numerics.Vector2 right, System.Numerics.Vector2 addend) { throw null; }
        public override readonly int GetHashCode() { throw null; }
        public static Vector2 GreaterThan(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static bool GreaterThanAll(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static bool GreaterThanAny(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static Vector2 GreaterThanOrEqual(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static bool GreaterThanOrEqualAll(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static bool GreaterThanOrEqualAny(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static System.Numerics.Vector2 Hypot(System.Numerics.Vector2 x, System.Numerics.Vector2 y) { throw null; }
        public static int IndexOf(System.Numerics.Vector2 vector, float value) { throw null; }
        public static int IndexOfWhereAllBitsSet(System.Numerics.Vector2 vector) { throw null; }
        public static System.Numerics.Vector2 IsEvenInteger(System.Numerics.Vector2 vector) { throw null; }
        public static System.Numerics.Vector2 IsFinite(System.Numerics.Vector2 vector) { throw null; }
        public static System.Numerics.Vector2 IsInfinity(System.Numerics.Vector2 vector) { throw null; }
        public static System.Numerics.Vector2 IsInteger(System.Numerics.Vector2 vector) { throw null; }
        public static System.Numerics.Vector2 IsNaN(System.Numerics.Vector2 vector) { throw null; }
        public static System.Numerics.Vector2 IsNegative(System.Numerics.Vector2 vector) { throw null; }
        public static System.Numerics.Vector2 IsNegativeInfinity(System.Numerics.Vector2 vector) { throw null; }
        public static System.Numerics.Vector2 IsNormal(System.Numerics.Vector2 vector) { throw null; }
        public static System.Numerics.Vector2 IsOddInteger(System.Numerics.Vector2 vector) { throw null; }
        public static System.Numerics.Vector2 IsPositive(System.Numerics.Vector2 vector) { throw null; }
        public static System.Numerics.Vector2 IsPositiveInfinity(System.Numerics.Vector2 vector) { throw null; }
        public static System.Numerics.Vector2 IsSubnormal(System.Numerics.Vector2 vector) { throw null; }
        public static System.Numerics.Vector2 IsZero(System.Numerics.Vector2 vector) { throw null; }
        public static int LastIndexOf(System.Numerics.Vector2 vector, float value) { throw null; }
        public static int LastIndexOfWhereAllBitsSet(System.Numerics.Vector2 vector) { throw null; }
        public readonly float Length() { throw null; }
        public readonly float LengthSquared() { throw null; }
        public static System.Numerics.Vector2 Lerp(System.Numerics.Vector2 value1, System.Numerics.Vector2 value2, float amount) { throw null; }
        public static System.Numerics.Vector2 Lerp(System.Numerics.Vector2 value1, System.Numerics.Vector2 value2, System.Numerics.Vector2 amount) { throw null; }
        public static Vector2 LessThan(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static bool LessThanAll(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static bool LessThanAny(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static Vector2 LessThanOrEqual(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static bool LessThanOrEqualAll(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static bool LessThanOrEqualAny(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        [CLSCompliant(false)]
        public static unsafe System.Numerics.Vector2 Load(float* source) { throw null; }
        [CLSCompliant(false)]
        public static unsafe System.Numerics.Vector2 LoadAligned(float* source) { throw null; }
        [CLSCompliant(false)]
        public static unsafe System.Numerics.Vector2 LoadAlignedNonTemporal(float* source) { throw null; }
        public static System.Numerics.Vector2 LoadUnsafe(ref readonly float source) { throw null; }
        [CLSCompliant(false)]
        public static System.Numerics.Vector2 LoadUnsafe(ref readonly float source, nuint elementOffset) { throw null; }
        public static System.Numerics.Vector2 Log(System.Numerics.Vector2 vector) { throw null; }
        public static System.Numerics.Vector2 Log2(System.Numerics.Vector2 vector) { throw null; }
        public static System.Numerics.Vector2 Max(System.Numerics.Vector2 value1, System.Numerics.Vector2 value2) { throw null; }
        public static System.Numerics.Vector2 MaxMagnitude(System.Numerics.Vector2 value1, System.Numerics.Vector2 value2) { throw null; }
        public static System.Numerics.Vector2 MaxMagnitudeNumber(System.Numerics.Vector2 value1, System.Numerics.Vector2 value2) { throw null; }
        public static System.Numerics.Vector2 MaxNative(System.Numerics.Vector2 value1, System.Numerics.Vector2 value2) { throw null; }
        public static System.Numerics.Vector2 MaxNumber(System.Numerics.Vector2 value1, System.Numerics.Vector2 value2) { throw null; }
        public static System.Numerics.Vector2 Min(System.Numerics.Vector2 value1, System.Numerics.Vector2 value2) { throw null; }
        public static System.Numerics.Vector2 MinMagnitude(System.Numerics.Vector2 value1, System.Numerics.Vector2 value2) { throw null; }
        public static System.Numerics.Vector2 MinMagnitudeNumber(System.Numerics.Vector2 value1, System.Numerics.Vector2 value2) { throw null; }
        public static System.Numerics.Vector2 MinNative(System.Numerics.Vector2 value1, System.Numerics.Vector2 value2) { throw null; }
        public static System.Numerics.Vector2 MinNumber(System.Numerics.Vector2 value1, System.Numerics.Vector2 value2) { throw null; }
        public static System.Numerics.Vector2 Multiply(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static System.Numerics.Vector2 Multiply(System.Numerics.Vector2 left, float right) { throw null; }
        public static System.Numerics.Vector2 Multiply(float left, System.Numerics.Vector2 right) { throw null; }
        public static System.Numerics.Vector2 MultiplyAddEstimate(System.Numerics.Vector2 left, System.Numerics.Vector2 right, System.Numerics.Vector2 addend) { throw null; }
        public static System.Numerics.Vector2 Negate(System.Numerics.Vector2 value) { throw null; }
        public static bool None(System.Numerics.Vector2 vector, float value) { throw null; }
        public static bool NoneWhereAllBitsSet(System.Numerics.Vector2 vector) { throw null; }
        public static System.Numerics.Vector2 Normalize(System.Numerics.Vector2 value) { throw null; }
        public static System.Numerics.Vector2 OnesComplement(System.Numerics.Vector2 value) { throw null; }
        public static System.Numerics.Vector2 operator +(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static System.Numerics.Vector2 operator &(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static System.Numerics.Vector2 operator |(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static System.Numerics.Vector2 operator /(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static System.Numerics.Vector2 operator /(System.Numerics.Vector2 value1, float value2) { throw null; }
        public static System.Numerics.Vector2 operator ^(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static bool operator ==(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static System.Numerics.Vector2 operator <<(System.Numerics.Vector2 value, int shiftAmount) { throw null; }
        public static bool operator !=(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static System.Numerics.Vector2 operator *(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static System.Numerics.Vector2 operator *(System.Numerics.Vector2 left, float right) { throw null; }
        public static System.Numerics.Vector2 operator *(float left, System.Numerics.Vector2 right) { throw null; }
        public static System.Numerics.Vector2 operator ~(System.Numerics.Vector2 value) { throw null; }
        public static System.Numerics.Vector2 operator >>(System.Numerics.Vector2 value, int shiftAmount) { throw null; }
        public static System.Numerics.Vector2 operator -(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public static System.Numerics.Vector2 operator -(System.Numerics.Vector2 value) { throw null; }
        public static System.Numerics.Vector2 operator +(System.Numerics.Vector2 value) { throw null; }
        public static System.Numerics.Vector2 operator >>>(System.Numerics.Vector2 value, int shiftAmount) { throw null; }
        public static System.Numerics.Vector2 RadiansToDegrees(System.Numerics.Vector2 radians) { throw null; }
        public static System.Numerics.Vector2 Round(System.Numerics.Vector2 vector) { throw null; }
        public static System.Numerics.Vector2 Round(System.Numerics.Vector2 vector, System.MidpointRounding mode) { throw null; }
        public static System.Numerics.Vector2 Reflect(System.Numerics.Vector2 vector, System.Numerics.Vector2 normal) { throw null; }
        public static System.Numerics.Vector2 Shuffle(System.Numerics.Vector2 vector, byte xIndex, byte yIndex) { throw null; }
        public static System.Numerics.Vector2 Sin(System.Numerics.Vector2 vector) { throw null; }
        public static (System.Numerics.Vector2 Sin, System.Numerics.Vector2 Cos) SinCos(System.Numerics.Vector2 vector) { throw null; }
        public static System.Numerics.Vector2 SquareRoot(System.Numerics.Vector2 value) { throw null; }
        public static float Sum(System.Numerics.Vector2 value) { throw null; }
        public static System.Numerics.Vector2 Subtract(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
        public override readonly string ToString() { throw null; }
        public readonly string ToString([System.Diagnostics.CodeAnalysis.StringSyntaxAttribute("NumericFormat")] string? format) { throw null; }
        public readonly string ToString([System.Diagnostics.CodeAnalysis.StringSyntaxAttribute("NumericFormat")] string? format, System.IFormatProvider? formatProvider) { throw null; }
        public static System.Numerics.Vector2 Transform(System.Numerics.Vector2 position, System.Numerics.Matrix3x2 matrix) { throw null; }
        public static System.Numerics.Vector2 Transform(System.Numerics.Vector2 position, System.Numerics.Matrix4x4 matrix) { throw null; }
        public static System.Numerics.Vector2 Transform(System.Numerics.Vector2 value, System.Numerics.Quaternion rotation) { throw null; }
        public static System.Numerics.Vector2 TransformNormal(System.Numerics.Vector2 normal, System.Numerics.Matrix3x2 matrix) { throw null; }
        public static System.Numerics.Vector2 TransformNormal(System.Numerics.Vector2 normal, System.Numerics.Matrix4x4 matrix) { throw null; }
        public static System.Numerics.Vector2 Truncate(System.Numerics.Vector2 vector) { throw null; }
        public static System.Numerics.Vector2 Xor(System.Numerics.Vector2 left, System.Numerics.Vector2 right) { throw null; }
    }
    public partial struct Vector3 : System.IEquatable<System.Numerics.Vector3>, System.IFormattable
    {
        public float X;
        public float Y;
        public float Z;
        public Vector3(System.Numerics.Vector2 value, float z) { throw null; }
        public Vector3(float value) { throw null; }
        public Vector3(float x, float y, float z) { throw null; }
        public Vector3(System.ReadOnlySpan<float> values) { throw null; }
        public static System.Numerics.Vector3 AllBitsSet { get { throw null; } }
        public static System.Numerics.Vector3 E { get { throw null; } }
        public static System.Numerics.Vector3 Epsilon { get { throw null; } }
        public static System.Numerics.Vector3 NaN { get { throw null; } }
        public static System.Numerics.Vector3 NegativeInfinity { get { throw null; } }
        public static System.Numerics.Vector3 NegativeZero { get { throw null; } }
        public static System.Numerics.Vector3 One { get { throw null; } }
        public static System.Numerics.Vector3 Pi { get { throw null; } }
        public static System.Numerics.Vector3 PositiveInfinity { get { throw null; } }
        public static System.Numerics.Vector3 Tau { get { throw null; } }
        public static System.Numerics.Vector3 UnitX { get { throw null; } }
        public static System.Numerics.Vector3 UnitY { get { throw null; } }
        public static System.Numerics.Vector3 UnitZ { get { throw null; } }
        public float this[int index] { readonly get { throw null; } set { throw null; } }
        public static System.Numerics.Vector3 Zero { get { throw null; } }
        public static System.Numerics.Vector3 Abs(System.Numerics.Vector3 value) { throw null; }
        public static System.Numerics.Vector3 Add(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static bool All(System.Numerics.Vector3 vector, float value) { throw null; }
        public static bool AllWhereAllBitsSet(System.Numerics.Vector3 vector) { throw null; }
        public static System.Numerics.Vector3 AndNot(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static bool Any(System.Numerics.Vector3 vector, float value) { throw null; }
        public static bool AnyWhereAllBitsSet(System.Numerics.Vector3 vector) { throw null; }
        public static System.Numerics.Vector3 BitwiseAnd(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static System.Numerics.Vector3 BitwiseOr(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static System.Numerics.Vector3 Clamp(System.Numerics.Vector3 value1, System.Numerics.Vector3 min, System.Numerics.Vector3 max) { throw null; }
        public static System.Numerics.Vector3 ClampNative(System.Numerics.Vector3 value1, System.Numerics.Vector3 min, System.Numerics.Vector3 max) { throw null; }
        public static System.Numerics.Vector3 ConditionalSelect(System.Numerics.Vector3 condition, System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static System.Numerics.Vector3 CopySign(System.Numerics.Vector3 value, System.Numerics.Vector3 sign) { throw null; }
        public static int Count(System.Numerics.Vector3 vector, float value) { throw null; }
        public static int CountWhereAllBitsSet(System.Numerics.Vector3 vector) { throw null; }
        public readonly void CopyTo(float[] array) { }
        public readonly void CopyTo(float[] array, int index) { }
        public readonly void CopyTo(System.Span<float> destination) { }
        public static System.Numerics.Vector3 Cos(System.Numerics.Vector3 vector) { throw null; }
        public static System.Numerics.Vector3 Create(float value) { throw null; }
        public static System.Numerics.Vector3 Create(System.Numerics.Vector2 vector, float z) { throw null; }
        public static System.Numerics.Vector3 Create(float x, float y, float z) { throw null; }
        public static System.Numerics.Vector3 Create(System.ReadOnlySpan<float> values) { throw null; }
        public static System.Numerics.Vector3 CreateScalar(float x) { throw null; }
        public static System.Numerics.Vector3 CreateScalarUnsafe(float x) { throw null; }
        public readonly bool TryCopyTo(System.Span<float> destination) { throw null; }
        public static System.Numerics.Vector3 Cross(System.Numerics.Vector3 vector1, System.Numerics.Vector3 vector2) { throw null; }
        public static System.Numerics.Vector3 DegreesToRadians(System.Numerics.Vector3 degrees) { throw null; }
        public static float Distance(System.Numerics.Vector3 value1, System.Numerics.Vector3 value2) { throw null; }
        public static float DistanceSquared(System.Numerics.Vector3 value1, System.Numerics.Vector3 value2) { throw null; }
        public static System.Numerics.Vector3 Divide(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static System.Numerics.Vector3 Divide(System.Numerics.Vector3 left, float divisor) { throw null; }
        public static float Dot(System.Numerics.Vector3 vector1, System.Numerics.Vector3 vector2) { throw null; }
        public readonly bool Equals(System.Numerics.Vector3 other) { throw null; }
        public override readonly bool Equals([System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] object? obj) { throw null; }
        public static Vector3 Equals(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static bool EqualsAll(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static bool EqualsAny(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static System.Numerics.Vector3 Exp(System.Numerics.Vector3 vector) { throw null; }
        public static System.Numerics.Vector3 FusedMultiplyAdd(System.Numerics.Vector3 left, System.Numerics.Vector3 right, System.Numerics.Vector3 addend) { throw null; }
        public override readonly int GetHashCode() { throw null; }
        public static Vector3 GreaterThan(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static bool GreaterThanAll(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static bool GreaterThanAny(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static Vector3 GreaterThanOrEqual(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static bool GreaterThanOrEqualAll(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static bool GreaterThanOrEqualAny(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static System.Numerics.Vector3 Hypot(System.Numerics.Vector3 x, System.Numerics.Vector3 y) { throw null; }
        public static int IndexOf(System.Numerics.Vector3 vector, float value) { throw null; }
        public static int IndexOfWhereAllBitsSet(System.Numerics.Vector3 vector) { throw null; }
        public static System.Numerics.Vector3 IsEvenInteger(System.Numerics.Vector3 vector) { throw null; }
        public static System.Numerics.Vector3 IsFinite(System.Numerics.Vector3 vector) { throw null; }
        public static System.Numerics.Vector3 IsInfinity(System.Numerics.Vector3 vector) { throw null; }
        public static System.Numerics.Vector3 IsInteger(System.Numerics.Vector3 vector) { throw null; }
        public static System.Numerics.Vector3 IsNaN(System.Numerics.Vector3 vector) { throw null; }
        public static System.Numerics.Vector3 IsNegative(System.Numerics.Vector3 vector) { throw null; }
        public static System.Numerics.Vector3 IsNegativeInfinity(System.Numerics.Vector3 vector) { throw null; }
        public static System.Numerics.Vector3 IsNormal(System.Numerics.Vector3 vector) { throw null; }
        public static System.Numerics.Vector3 IsOddInteger(System.Numerics.Vector3 vector) { throw null; }
        public static System.Numerics.Vector3 IsPositive(System.Numerics.Vector3 vector) { throw null; }
        public static System.Numerics.Vector3 IsPositiveInfinity(System.Numerics.Vector3 vector) { throw null; }
        public static System.Numerics.Vector3 IsSubnormal(System.Numerics.Vector3 vector) { throw null; }
        public static System.Numerics.Vector3 IsZero(System.Numerics.Vector3 vector) { throw null; }
        public static int LastIndexOf(System.Numerics.Vector3 vector, float value) { throw null; }
        public static int LastIndexOfWhereAllBitsSet(System.Numerics.Vector3 vector) { throw null; }
        public readonly float Length() { throw null; }
        public readonly float LengthSquared() { throw null; }
        public static System.Numerics.Vector3 Lerp(System.Numerics.Vector3 value1, System.Numerics.Vector3 value2, float amount) { throw null; }
        public static System.Numerics.Vector3 Lerp(System.Numerics.Vector3 value1, System.Numerics.Vector3 value2, System.Numerics.Vector3 amount) { throw null; }
        public static Vector3 LessThan(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static bool LessThanAll(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static bool LessThanAny(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static Vector3 LessThanOrEqual(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static bool LessThanOrEqualAll(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static bool LessThanOrEqualAny(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        [CLSCompliant(false)]
        public static unsafe System.Numerics.Vector3 Load(float* source) { throw null; }
        [CLSCompliant(false)]
        public static unsafe System.Numerics.Vector3 LoadAligned(float* source) { throw null; }
        [CLSCompliant(false)]
        public static unsafe System.Numerics.Vector3 LoadAlignedNonTemporal(float* source) { throw null; }
        public static System.Numerics.Vector3 LoadUnsafe(ref readonly float source) { throw null; }
        [CLSCompliant(false)]
        public static System.Numerics.Vector3 LoadUnsafe(ref readonly float source, nuint elementOffset) { throw null; }
        public static System.Numerics.Vector3 Log(System.Numerics.Vector3 vector) { throw null; }
        public static System.Numerics.Vector3 Log2(System.Numerics.Vector3 vector) { throw null; }
        public static System.Numerics.Vector3 Max(System.Numerics.Vector3 value1, System.Numerics.Vector3 value2) { throw null; }
        public static System.Numerics.Vector3 MaxMagnitude(System.Numerics.Vector3 value1, System.Numerics.Vector3 value2) { throw null; }
        public static System.Numerics.Vector3 MaxMagnitudeNumber(System.Numerics.Vector3 value1, System.Numerics.Vector3 value2) { throw null; }
        public static System.Numerics.Vector3 MaxNative(System.Numerics.Vector3 value1, System.Numerics.Vector3 value2) { throw null; }
        public static System.Numerics.Vector3 MaxNumber(System.Numerics.Vector3 value1, System.Numerics.Vector3 value2) { throw null; }
        public static System.Numerics.Vector3 Min(System.Numerics.Vector3 value1, System.Numerics.Vector3 value2) { throw null; }
        public static System.Numerics.Vector3 MinMagnitude(System.Numerics.Vector3 value1, System.Numerics.Vector3 value2) { throw null; }
        public static System.Numerics.Vector3 MinMagnitudeNumber(System.Numerics.Vector3 value1, System.Numerics.Vector3 value2) { throw null; }
        public static System.Numerics.Vector3 MinNative(System.Numerics.Vector3 value1, System.Numerics.Vector3 value2) { throw null; }
        public static System.Numerics.Vector3 MinNumber(System.Numerics.Vector3 value1, System.Numerics.Vector3 value2) { throw null; }
        public static System.Numerics.Vector3 Multiply(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static System.Numerics.Vector3 Multiply(System.Numerics.Vector3 left, float right) { throw null; }
        public static System.Numerics.Vector3 Multiply(float left, System.Numerics.Vector3 right) { throw null; }
        public static System.Numerics.Vector3 MultiplyAddEstimate(System.Numerics.Vector3 left, System.Numerics.Vector3 right, System.Numerics.Vector3 addend) { throw null; }
        public static System.Numerics.Vector3 Negate(System.Numerics.Vector3 value) { throw null; }
        public static bool None(System.Numerics.Vector3 vector, float value) { throw null; }
        public static bool NoneWhereAllBitsSet(System.Numerics.Vector3 vector) { throw null; }
        public static System.Numerics.Vector3 Normalize(System.Numerics.Vector3 value) { throw null; }
        public static System.Numerics.Vector3 OnesComplement(System.Numerics.Vector3 value) { throw null; }
        public static System.Numerics.Vector3 operator +(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static System.Numerics.Vector3 operator &(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static System.Numerics.Vector3 operator |(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static System.Numerics.Vector3 operator /(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static System.Numerics.Vector3 operator /(System.Numerics.Vector3 value1, float value2) { throw null; }
        public static System.Numerics.Vector3 operator ^(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static bool operator ==(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static System.Numerics.Vector3 operator <<(System.Numerics.Vector3 value, int shiftAmount) { throw null; }
        public static bool operator !=(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static System.Numerics.Vector3 operator *(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static System.Numerics.Vector3 operator *(System.Numerics.Vector3 left, float right) { throw null; }
        public static System.Numerics.Vector3 operator *(float left, System.Numerics.Vector3 right) { throw null; }
        public static System.Numerics.Vector3 operator ~(System.Numerics.Vector3 value) { throw null; }
        public static System.Numerics.Vector3 operator >>(System.Numerics.Vector3 value, int shiftAmount) { throw null; }
        public static System.Numerics.Vector3 operator -(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static System.Numerics.Vector3 operator -(System.Numerics.Vector3 value) { throw null; }
        public static System.Numerics.Vector3 operator +(System.Numerics.Vector3 value) { throw null; }
        public static System.Numerics.Vector3 operator >>>(System.Numerics.Vector3 value, int shiftAmount) { throw null; }
        public static System.Numerics.Vector3 RadiansToDegrees(System.Numerics.Vector3 radians) { throw null; }
        public static System.Numerics.Vector3 Reflect(System.Numerics.Vector3 vector, System.Numerics.Vector3 normal) { throw null; }
        public static System.Numerics.Vector3 Round(System.Numerics.Vector3 vector) { throw null; }
        public static System.Numerics.Vector3 Round(System.Numerics.Vector3 vector, System.MidpointRounding mode) { throw null; }
        public static System.Numerics.Vector3 Shuffle(System.Numerics.Vector3 vector, byte xIndex, byte yIndex, byte zIndex) { throw null; }
        public static System.Numerics.Vector3 Sin(System.Numerics.Vector3 vector) { throw null; }
        public static (System.Numerics.Vector3 Sin, System.Numerics.Vector3 Cos) SinCos(System.Numerics.Vector3 vector) { throw null; }
        public static System.Numerics.Vector3 SquareRoot(System.Numerics.Vector3 value) { throw null; }
        public static System.Numerics.Vector3 Subtract(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
        public static float Sum(System.Numerics.Vector3 value) { throw null; }
        public override readonly string ToString() { throw null; }
        public readonly string ToString([System.Diagnostics.CodeAnalysis.StringSyntaxAttribute("NumericFormat")] string? format) { throw null; }
        public readonly string ToString([System.Diagnostics.CodeAnalysis.StringSyntaxAttribute("NumericFormat")] string? format, System.IFormatProvider? formatProvider) { throw null; }
        public static System.Numerics.Vector3 Transform(System.Numerics.Vector3 position, System.Numerics.Matrix4x4 matrix) { throw null; }
        public static System.Numerics.Vector3 Transform(System.Numerics.Vector3 value, System.Numerics.Quaternion rotation) { throw null; }
        public static System.Numerics.Vector3 TransformNormal(System.Numerics.Vector3 normal, System.Numerics.Matrix4x4 matrix) { throw null; }
        public static System.Numerics.Vector3 Truncate(System.Numerics.Vector3 vector) { throw null; }
        public static System.Numerics.Vector3 Xor(System.Numerics.Vector3 left, System.Numerics.Vector3 right) { throw null; }
    }
    public partial struct Vector4 : System.IEquatable<System.Numerics.Vector4>, System.IFormattable
    {
        public float X;
        public float Y;
        public float Z;
        public float W;
        public Vector4(System.Numerics.Vector2 value, float z, float w) { throw null; }
        public Vector4(System.Numerics.Vector3 value, float w) { throw null; }
        public Vector4(float value) { throw null; }
        public Vector4(float x, float y, float z, float w) { throw null; }
        public Vector4(System.ReadOnlySpan<float> values) { throw null; }
        public static System.Numerics.Vector4 AllBitsSet { get { throw null; } }
        public static System.Numerics.Vector4 E { get { throw null; } }
        public static System.Numerics.Vector4 Epsilon { get { throw null; } }
        public static System.Numerics.Vector4 NaN { get { throw null; } }
        public static System.Numerics.Vector4 NegativeInfinity { get { throw null; } }
        public static System.Numerics.Vector4 NegativeZero { get { throw null; } }
        public static System.Numerics.Vector4 One { get { throw null; } }
        public static System.Numerics.Vector4 Pi { get { throw null; } }
        public static System.Numerics.Vector4 PositiveInfinity { get { throw null; } }
        public static System.Numerics.Vector4 Tau { get { throw null; } }
        public static System.Numerics.Vector4 UnitW { get { throw null; } }
        public static System.Numerics.Vector4 UnitX { get { throw null; } }
        public static System.Numerics.Vector4 UnitY { get { throw null; } }
        public static System.Numerics.Vector4 UnitZ { get { throw null; } }
        public float this[int index] { readonly get { throw null; } set { throw null; } }
        public static System.Numerics.Vector4 Zero { get { throw null; } }
        public static System.Numerics.Vector4 Abs(System.Numerics.Vector4 value) { throw null; }
        public static System.Numerics.Vector4 Add(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static bool All(System.Numerics.Vector4 vector, float value) { throw null; }
        public static bool AllWhereAllBitsSet(System.Numerics.Vector4 vector) { throw null; }
        public static System.Numerics.Vector4 AndNot(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static bool Any(System.Numerics.Vector4 vector, float value) { throw null; }
        public static bool AnyWhereAllBitsSet(System.Numerics.Vector4 vector) { throw null; }
        public static System.Numerics.Vector4 BitwiseAnd(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static System.Numerics.Vector4 BitwiseOr(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static System.Numerics.Vector4 Clamp(System.Numerics.Vector4 value1, System.Numerics.Vector4 min, System.Numerics.Vector4 max) { throw null; }
        public static System.Numerics.Vector4 ClampNative(System.Numerics.Vector4 value1, System.Numerics.Vector4 min, System.Numerics.Vector4 max) { throw null; }
        public static System.Numerics.Vector4 ConditionalSelect(System.Numerics.Vector4 condition, System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static System.Numerics.Vector4 CopySign(System.Numerics.Vector4 value, System.Numerics.Vector4 sign) { throw null; }
        public static int Count(System.Numerics.Vector4 vector, float value) { throw null; }
        public static int CountWhereAllBitsSet(System.Numerics.Vector4 vector) { throw null; }
        public readonly void CopyTo(float[] array) { }
        public readonly void CopyTo(float[] array, int index) { }
        public readonly void CopyTo(System.Span<float> destination) { }
        public static System.Numerics.Vector4 Cos(System.Numerics.Vector4 vector) { throw null; }
        public static System.Numerics.Vector4 Create(float value) { throw null; }
        public static System.Numerics.Vector4 Create(System.Numerics.Vector2 vector, float z, float w) { throw null; }
        public static System.Numerics.Vector4 Create(System.Numerics.Vector3 vector, float w) { throw null; }
        public static System.Numerics.Vector4 Create(float x, float y, float z, float w) { throw null; }
        public static System.Numerics.Vector4 Create(System.ReadOnlySpan<float> values) { throw null; }
        public static System.Numerics.Vector4 CreateScalar(float x) { throw null; }
        public static System.Numerics.Vector4 CreateScalarUnsafe(float x) { throw null; }
        public readonly bool TryCopyTo(System.Span<float> destination) { throw null; }
        public static System.Numerics.Vector4 DegreesToRadians(System.Numerics.Vector4 degrees) { throw null; }
        public static float Distance(System.Numerics.Vector4 value1, System.Numerics.Vector4 value2) { throw null; }
        public static float DistanceSquared(System.Numerics.Vector4 value1, System.Numerics.Vector4 value2) { throw null; }
        public static System.Numerics.Vector4 Divide(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static System.Numerics.Vector4 Divide(System.Numerics.Vector4 left, float divisor) { throw null; }
        public static float Dot(System.Numerics.Vector4 vector1, System.Numerics.Vector4 vector2) { throw null; }
        public static System.Numerics.Vector4 Cross(System.Numerics.Vector4 vector1, System.Numerics.Vector4 vector2) { throw null; }
        public readonly bool Equals(System.Numerics.Vector4 other) { throw null; }
        public override readonly bool Equals([System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] object? obj) { throw null; }
        public static Vector4 Equals(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static bool EqualsAll(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static bool EqualsAny(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static System.Numerics.Vector4 Exp(System.Numerics.Vector4 vector) { throw null; }
        public static System.Numerics.Vector4 FusedMultiplyAdd(System.Numerics.Vector4 left, System.Numerics.Vector4 right, System.Numerics.Vector4 addend) { throw null; }
        public override readonly int GetHashCode() { throw null; }
        public static Vector4 GreaterThan(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static bool GreaterThanAll(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static bool GreaterThanAny(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static Vector4 GreaterThanOrEqual(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static bool GreaterThanOrEqualAll(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static bool GreaterThanOrEqualAny(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static System.Numerics.Vector4 Hypot(System.Numerics.Vector4 x, System.Numerics.Vector4 y) { throw null; }
        public static int IndexOf(System.Numerics.Vector4 vector, float value) { throw null; }
        public static int IndexOfWhereAllBitsSet(System.Numerics.Vector4 vector) { throw null; }
        public static System.Numerics.Vector4 IsEvenInteger(System.Numerics.Vector4 vector) { throw null; }
        public static System.Numerics.Vector4 IsFinite(System.Numerics.Vector4 vector) { throw null; }
        public static System.Numerics.Vector4 IsInfinity(System.Numerics.Vector4 vector) { throw null; }
        public static System.Numerics.Vector4 IsInteger(System.Numerics.Vector4 vector) { throw null; }
        public static System.Numerics.Vector4 IsNaN(System.Numerics.Vector4 vector) { throw null; }
        public static System.Numerics.Vector4 IsNegative(System.Numerics.Vector4 vector) { throw null; }
        public static System.Numerics.Vector4 IsNegativeInfinity(System.Numerics.Vector4 vector) { throw null; }
        public static System.Numerics.Vector4 IsNormal(System.Numerics.Vector4 vector) { throw null; }
        public static System.Numerics.Vector4 IsOddInteger(System.Numerics.Vector4 vector) { throw null; }
        public static System.Numerics.Vector4 IsPositive(System.Numerics.Vector4 vector) { throw null; }
        public static System.Numerics.Vector4 IsPositiveInfinity(System.Numerics.Vector4 vector) { throw null; }
        public static System.Numerics.Vector4 IsSubnormal(System.Numerics.Vector4 vector) { throw null; }
        public static System.Numerics.Vector4 IsZero(System.Numerics.Vector4 vector) { throw null; }
        public static int LastIndexOf(System.Numerics.Vector4 vector, float value) { throw null; }
        public static int LastIndexOfWhereAllBitsSet(System.Numerics.Vector4 vector) { throw null; }
        public readonly float Length() { throw null; }
        public readonly float LengthSquared() { throw null; }
        public static System.Numerics.Vector4 Lerp(System.Numerics.Vector4 value1, System.Numerics.Vector4 value2, float amount) { throw null; }
        public static System.Numerics.Vector4 Lerp(System.Numerics.Vector4 value1, System.Numerics.Vector4 value2, System.Numerics.Vector4 amount) { throw null; }
        public static Vector4 LessThan(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static bool LessThanAll(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static bool LessThanAny(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static Vector4 LessThanOrEqual(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static bool LessThanOrEqualAll(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static bool LessThanOrEqualAny(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static System.Numerics.Vector4 Log(System.Numerics.Vector4 vector) { throw null; }
        public static System.Numerics.Vector4 Log2(System.Numerics.Vector4 vector) { throw null; }
        [CLSCompliant(false)]
        public static unsafe System.Numerics.Vector4 Load(float* source) { throw null; }
        [CLSCompliant(false)]
        public static unsafe System.Numerics.Vector4 LoadAligned(float* source) { throw null; }
        [CLSCompliant(false)]
        public static unsafe System.Numerics.Vector4 LoadAlignedNonTemporal(float* source) { throw null; }
        public static System.Numerics.Vector4 LoadUnsafe(ref readonly float source) { throw null; }
        [CLSCompliant(false)]
        public static System.Numerics.Vector4 LoadUnsafe(ref readonly float source, nuint elementOffset) { throw null; }
        public static System.Numerics.Vector4 Max(System.Numerics.Vector4 value1, System.Numerics.Vector4 value2) { throw null; }
        public static System.Numerics.Vector4 MaxMagnitude(System.Numerics.Vector4 value1, System.Numerics.Vector4 value2) { throw null; }
        public static System.Numerics.Vector4 MaxMagnitudeNumber(System.Numerics.Vector4 value1, System.Numerics.Vector4 value2) { throw null; }
        public static System.Numerics.Vector4 MaxNative(System.Numerics.Vector4 value1, System.Numerics.Vector4 value2) { throw null; }
        public static System.Numerics.Vector4 MaxNumber(System.Numerics.Vector4 value1, System.Numerics.Vector4 value2) { throw null; }
        public static System.Numerics.Vector4 Min(System.Numerics.Vector4 value1, System.Numerics.Vector4 value2) { throw null; }
        public static System.Numerics.Vector4 MinMagnitude(System.Numerics.Vector4 value1, System.Numerics.Vector4 value2) { throw null; }
        public static System.Numerics.Vector4 MinMagnitudeNumber(System.Numerics.Vector4 value1, System.Numerics.Vector4 value2) { throw null; }
        public static System.Numerics.Vector4 MinNative(System.Numerics.Vector4 value1, System.Numerics.Vector4 value2) { throw null; }
        public static System.Numerics.Vector4 MinNumber(System.Numerics.Vector4 value1, System.Numerics.Vector4 value2) { throw null; }
        public static System.Numerics.Vector4 Multiply(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static System.Numerics.Vector4 Multiply(System.Numerics.Vector4 left, float right) { throw null; }
        public static System.Numerics.Vector4 Multiply(float left, System.Numerics.Vector4 right) { throw null; }
        public static System.Numerics.Vector4 MultiplyAddEstimate(System.Numerics.Vector4 left, System.Numerics.Vector4 right, System.Numerics.Vector4 addend) { throw null; }
        public static System.Numerics.Vector4 Negate(System.Numerics.Vector4 value) { throw null; }
        public static bool None(System.Numerics.Vector4 vector, float value) { throw null; }
        public static bool NoneWhereAllBitsSet(System.Numerics.Vector4 vector) { throw null; }
        public static System.Numerics.Vector4 Normalize(System.Numerics.Vector4 vector) { throw null; }
        public static System.Numerics.Vector4 OnesComplement(System.Numerics.Vector4 value) { throw null; }
        public static System.Numerics.Vector4 operator +(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static System.Numerics.Vector4 operator &(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static System.Numerics.Vector4 operator |(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static System.Numerics.Vector4 operator /(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static System.Numerics.Vector4 operator /(System.Numerics.Vector4 value1, float value2) { throw null; }
        public static System.Numerics.Vector4 operator ^(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static bool operator ==(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static System.Numerics.Vector4 operator <<(System.Numerics.Vector4 value, int shiftAmount) { throw null; }
        public static bool operator !=(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static System.Numerics.Vector4 operator *(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static System.Numerics.Vector4 operator *(System.Numerics.Vector4 left, float right) { throw null; }
        public static System.Numerics.Vector4 operator *(float left, System.Numerics.Vector4 right) { throw null; }
        public static System.Numerics.Vector4 operator ~(System.Numerics.Vector4 value) { throw null; }
        public static System.Numerics.Vector4 operator >>(System.Numerics.Vector4 value, int shiftAmount) { throw null; }
        public static System.Numerics.Vector4 operator -(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static System.Numerics.Vector4 operator -(System.Numerics.Vector4 value) { throw null; }
        public static System.Numerics.Vector4 operator +(System.Numerics.Vector4 value) { throw null; }
        public static System.Numerics.Vector4 operator >>>(System.Numerics.Vector4 value, int shiftAmount) { throw null; }
        public static System.Numerics.Vector4 RadiansToDegrees(System.Numerics.Vector4 radians) { throw null; }
        public static System.Numerics.Vector4 Round(System.Numerics.Vector4 vector) { throw null; }
        public static System.Numerics.Vector4 Round(System.Numerics.Vector4 vector, System.MidpointRounding mode) { throw null; }
        public static System.Numerics.Vector4 Shuffle(System.Numerics.Vector4 vector, byte xIndex, byte yIndex, byte zIndex, byte wIndex) { throw null; }
        public static System.Numerics.Vector4 Sin(System.Numerics.Vector4 vector) { throw null; }
        public static (System.Numerics.Vector4 Sin, System.Numerics.Vector4 Cos) SinCos(System.Numerics.Vector4 vector) { throw null; }
        public static System.Numerics.Vector4 SquareRoot(System.Numerics.Vector4 value) { throw null; }
        public static System.Numerics.Vector4 Subtract(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
        public static float Sum(System.Numerics.Vector4 value) { throw null; }
        public override readonly string ToString() { throw null; }
        public readonly string ToString([System.Diagnostics.CodeAnalysis.StringSyntaxAttribute("NumericFormat")] string? format) { throw null; }
        public readonly string ToString([System.Diagnostics.CodeAnalysis.StringSyntaxAttribute("NumericFormat")] string? format, System.IFormatProvider? formatProvider) { throw null; }
        public static System.Numerics.Vector4 Transform(System.Numerics.Vector2 position, System.Numerics.Matrix4x4 matrix) { throw null; }
        public static System.Numerics.Vector4 Transform(System.Numerics.Vector2 value, System.Numerics.Quaternion rotation) { throw null; }
        public static System.Numerics.Vector4 Transform(System.Numerics.Vector3 position, System.Numerics.Matrix4x4 matrix) { throw null; }
        public static System.Numerics.Vector4 Transform(System.Numerics.Vector3 value, System.Numerics.Quaternion rotation) { throw null; }
        public static System.Numerics.Vector4 Transform(System.Numerics.Vector4 vector, System.Numerics.Matrix4x4 matrix) { throw null; }
        public static System.Numerics.Vector4 Transform(System.Numerics.Vector4 value, System.Numerics.Quaternion rotation) { throw null; }
        public static System.Numerics.Vector4 Truncate(System.Numerics.Vector4 vector) { throw null; }
        public static System.Numerics.Vector4 Xor(System.Numerics.Vector4 left, System.Numerics.Vector4 right) { throw null; }
    }
    public readonly partial struct Vector<T> : System.IEquatable<System.Numerics.Vector<T>>, System.IFormattable
    {
        private readonly int _dummyPrimitive;
        public Vector(System.ReadOnlySpan<byte> values) { throw null; }
        public Vector(System.ReadOnlySpan<T> values) { throw null; }
        [System.Runtime.CompilerServices.OverloadResolutionPriorityAttribute(-1)]
        public Vector(System.Span<T> values) { throw null; }
        public Vector(T value) { throw null; }
        public Vector(T[] values) { throw null; }
        public Vector(T[] values, int index) { throw null; }
        public static System.Numerics.Vector<T> AllBitsSet { get { throw null; } }
        public static int Count { get { throw null; } }
        public static System.Numerics.Vector<T> Indices { get { throw null; } }
        public static bool IsSupported { get { throw null; } }
        public T this[int index] { get { throw null; } }
        public static System.Numerics.Vector<T> One { get { throw null; } }
        public static System.Numerics.Vector<T> Zero { get { throw null; } }
        public void CopyTo(System.Span<byte> destination) { }
        public void CopyTo(System.Span<T> destination) { }
        public void CopyTo(T[] destination) { }
        public void CopyTo(T[] destination, int startIndex) { }
        public bool Equals(System.Numerics.Vector<T> other) { throw null; }
        public override bool Equals([System.Diagnostics.CodeAnalysis.NotNullWhenAttribute(true)] object? obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Numerics.Vector<T> operator +(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> operator &(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> operator |(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> operator /(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> operator /(System.Numerics.Vector<T> left, T right) { throw null; }
        public static bool operator ==(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> operator ^(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static explicit operator System.Numerics.Vector<System.Byte> (System.Numerics.Vector<T> value) { throw null; }
        public static explicit operator System.Numerics.Vector<System.Double> (System.Numerics.Vector<T> value) { throw null; }
        public static explicit operator System.Numerics.Vector<System.Int16> (System.Numerics.Vector<T> value) { throw null; }
        public static explicit operator System.Numerics.Vector<System.Int32> (System.Numerics.Vector<T> value) { throw null; }
        public static explicit operator System.Numerics.Vector<System.Int64> (System.Numerics.Vector<T> value) { throw null; }
        public static explicit operator System.Numerics.Vector<nint> (System.Numerics.Vector<T> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator System.Numerics.Vector<nuint> (System.Numerics.Vector<T> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator System.Numerics.Vector<System.SByte> (System.Numerics.Vector<T> value) { throw null; }
        public static explicit operator System.Numerics.Vector<System.Single> (System.Numerics.Vector<T> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator System.Numerics.Vector<System.UInt16> (System.Numerics.Vector<T> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator System.Numerics.Vector<System.UInt32> (System.Numerics.Vector<T> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator System.Numerics.Vector<System.UInt64> (System.Numerics.Vector<T> value) { throw null; }
        public static bool operator !=(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> operator <<(System.Numerics.Vector<T> value, int shiftCount) { throw null; }
        public static System.Numerics.Vector<T> operator *(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> operator *(System.Numerics.Vector<T> value, T factor) { throw null; }
        public static System.Numerics.Vector<T> operator *(T factor, System.Numerics.Vector<T> value) { throw null; }
        public static System.Numerics.Vector<T> operator ~(System.Numerics.Vector<T> value) { throw null; }
        public static System.Numerics.Vector<T> operator >>(System.Numerics.Vector<T> value, int shiftCount) { throw null; }
        public static System.Numerics.Vector<T> operator -(System.Numerics.Vector<T> left, System.Numerics.Vector<T> right) { throw null; }
        public static System.Numerics.Vector<T> operator -(System.Numerics.Vector<T> value) { throw null; }
        public static System.Numerics.Vector<T> operator +(System.Numerics.Vector<T> value) { throw null; }
        public static System.Numerics.Vector<T> operator >>>(System.Numerics.Vector<T> value, int shiftCount) { throw null; }
        public override string ToString() { throw null; }
        public string ToString([System.Diagnostics.CodeAnalysis.StringSyntaxAttribute("NumericFormat")] string? format) { throw null; }
        public string ToString([System.Diagnostics.CodeAnalysis.StringSyntaxAttribute("NumericFormat")] string? format, System.IFormatProvider? formatProvider) { throw null; }
        public bool TryCopyTo(System.Span<byte> destination) { throw null; }
        public bool TryCopyTo(System.Span<T> destination) { throw null; }
    }
}
