﻿
using System;
using System.Collections.Generic;

namespace U3D.Class
{
	#region enumz
	public enum SFtype
	{
		Asset = 0,
		AB = 1,
	}
	
	public enum BuildTarget
    {
        UnknownPlatform = 3716,
        DashboardWidget = 1,
        StandaloneOSX = 2,
        StandaloneOSXPPC = 3,
        StandaloneOSXIntel = 4,
        StandaloneWindows,
        WebPlayer,
        WebPlayerStreamed,
        Wii = 8,
        iOS = 9,
        PS3,
        XBOX360,
        Android = 13,
        StandaloneGLESEmu = 14,
        NaCl = 16,
        StandaloneLinux = 17,
        FlashPlayer = 18,
        StandaloneWindows64 = 19,
        WebGL,
        WSAPlayer,
        StandaloneLinux64 = 24,
        StandaloneLinuxUniversal,
        WP8Player,
        StandaloneOSXIntel64,
        BlackBerry,
        Tizen,
        PSP2,
        PS4,
        PSM,
        XboxOne,
        SamsungTV,
        N3DS,
        WiiU,
        tvOS,
        Switch,
        NoTarget = -2
    }
	
	public enum ClassIDType
	{
		Object							= 0,
		
		// =====================================
		// Runetime section
		// =====================================

		GameObject						= 1,
		Component						= 2,
		LevelGameManager				= 3,
		Transform						= 4,
		TimeManager						= 5,
		GlobalGameManager				= 6,
		BehaviourManager				= 7,
		Behaviour						= 8,
		GameManager						= 9,
		AudioManager					= 11,
		ParticleAnimator				= 12,
		InputManager					= 13,
		EllipsoidParticleEmitter		= 15,
		Filter							= 16,
		Pipeline						= 17,
		EditorExtension					= 18,
		Physics2DSettings				= 19,
		Camera							= 20,
		Material						= 21,
		MeshRenderer					= 23,
		Renderer						= 25,
		ParticleRenderer				= 26,
		Texture							= 27,
		Texture2D						= 28,
		Scene							= -29,
		SceneSettings					= -29,
		OcclusionCullingSettings		= 29,
		RenderManager					= -30,
		GraphicsSettings				= 30,
		PipelineManager					= 31,
		MeshFilter						= 33,
		BaseBehaviourManager			= 34,
		LateBehaviourManager			= 35,
		OcclusionPortal					= 41,
		Mesh							= 43,
		Skybox							= 45,
		FixedBehaviourManager			= 46,
		QualitySettings					= 47,
		Shader							= 48,
		Script							= -49,
		TextAsset						= 49,
		Rigidbody2D						= 50,
		Physics2DManager				= 51,
		NotificationManager				= 52,
		Collider2D						= 53,
		Rigidbody						= 54,
		PhysicsManager					= 55,
		Collider						= 56,
		Joint							= 57,
		CircleCollider2D				= 58,
		HingeJoint						= 59,
		PolygonCollider2D				= 60,
		BoxCollider2D					= 61,
		PhysicsMaterial2D				= 62,
		UpdateManager					= 63,
		MeshCollider					= 64,
		BoxCollider						= 65,
		SpriteCollider2D				= -66,
		CompositeCollider2D				= 66,
		RenderLayer						= 67,
		EdgeCollider2D					= 68,
		CapsuleCollider2D				= 70,
		AnimationManager				= 71,
		ComputeShader					= 72,
		AnimationClip					= 74,
		ConstantForce					= 75,
		WorldParticleCollider			= 76,
		TagManager						= 78,
		AudioListener					= 81,
		AudioSource						= 82,
		AudioClip						= 83,
		RenderTexture					= 84,
		CustomRenderTexture				= 86,
		MeshParticleEmitter				= 87,
		ParticleEmitter					= 88,
		Cubemap							= 89,
		Avatar							= 90,
		AnimatorController				= 91,
		GUILayer						= 92,
		RuntimeAnimatorController		= 93,
		ScriptMapper					= 94,
		Animator						= 95,
		TrailRenderer					= 96,
		DelayedCallManager				= 98,
		TextMesh						= 102,
		RenderSettings					= 104,
		Light							= 108,
		CGProgram						= 109,
		BaseAnimationTrack				= 110,
		Animation						= 111,
		MonoBehaviour					= 114,
		MonoScript						= 0x73,
		MonoManager						= 116,
		Texture3D						= 117,
		NewAnimationTrack				= 118,
		Projector						= 119,
		LineRenderer					= 120,
		Flare							= 121,
		Halo							= 122,
		LensFlare						= 123,
		FlareLayer						= 124,
		HaloLayer						= 125,
		NavMeshLayers					= -126,
		NavMeshAreas					= -126,
		NavMeshProjectSettings			= 126,
		HaloManager						= 127,
		Font							= 128,
		PlayerSettings					= 129,
		NamedObject						= 130,
		GUITexture						= 131,
		GUIText							= 132,
		GUIElement						= 133,
		PhysicMaterial					= 134,
		SphereCollider					= 135,
		CapsuleCollider					= 136,
		SkinnedMeshFilter				= -137,
		SkinnedMeshRenderer				= 137,
		FixedJoint						= 138,
		RaycastCollider					= 140,
		BuildSettings					= 141,
		AssetBundle						= 0x8E,
		CharacterController				= 143,
		CharacterJoint					= 144,
		SpringJoint						= 145,
		WheelCollider					= 146,
		ResourceManager					= 147,
		NetworkView						= 148,
		NetworkManager					= 149,
		PreloadData						= 150,
		MovieTexture					= 152,
		ConfigurableJoint				= 153,
		TerrainCollider					= 154,
		MasterServerInterface			= 155,
		TerrainData						= 156,
		LightmapSettings				= 157,
		WebCamTexture					= 158,
		EditorSettings					= 159,
		InteractiveCloth				= 160,
		ClothRenderer					= 161,
		EditorUserSettings				= 162,
		SkinnedCloth					= 163,
		AudioReverbFilter				= 164,
		AudioHighPassFilter				= 165,
		AudioChorusFilter				= 166,
		AudioReverbZone					= 167,
		AudioEchoFilter					= 168,
		AudioLowPassFilter				= 169,
		AudioDistortionFilter			= 170,
		SparseTexture					= 171,
		AudioBehaviour					= 180,
		AudioFilter						= 181,
		WindZone						= 182,
		Cloth							= 183,
		SubstanceArchive				= 184,
		ProceduralMaterial				= 185,
		ProceduralTexture				= 186,
		Texture2DArray					= 187,
		CubemapArray					= 188,
		OffMeshLink						= 191,
		OcclusionArea					= 192,
		Tree							= 193,
		NavMesh							= -194,
		NavMeshObsolete					= 194,
		NavMeshAgent					= 195,
		NavMeshSettings					= 196,
		LightProbesLegacy				= 197,
		ParticleSystem					= 198,
		ParticleSystemRenderer			= 199,
		ShaderVariantCollection			= 200,
		LODGroup						= 205,
		BlendTree						= 206,
		Motion							= 207,
		NavMeshObstacle					= 208,
		SortingGroup					= 210,
		//TerrainInstance				= 210,
		SpriteRenderer					= 212,
		Sprite							= 213,
		CachedSpriteAtlas				= 214,
		ReflectionProbe					= 215,
		ReflectionProbes				= 216,
		Terrain							= 218,
		LightProbeGroup					= 220,
		AnimatorOverrideController		= 221,
		CanvasRenderer					= 222,
		Canvas							= 223,
		RectTransform					= 224,
		CanvasGroup						= 225,
		BillboardAsset					= 226,
		BillboardRenderer				= 227,
		SpeedTreeWindAsset				= 228,
		AnchoredJoint2D					= 229,
		Joint2D							= 230,
		SpringJoint2D					= 231,
		DistanceJoint2D					= 232,
		HingeJoint2D					= 233,
		SliderJoint2D					= 234,
		WheelJoint2D					= 235,
		ClusterInputManager				= 236,
		BaseVideoTexture				= 237,
		NavMeshData						= 238,
		AudioMixer						= 240,
		AudioMixerController			= 241,
		AudioMixerGroupController		= 243,
		AudioMixerEffectController		= 244,
		AudioMixerSnapshotController	= 245,
		PhysicsUpdateBehaviour2D		= 246,
		ConstantForce2D					= 247,
		Effector2D						= 248,
		AreaEffector2D					= 249,
		PointEffector2D					= 250,
		PlatformEffector2D				= 251,
		SurfaceEffector2D				= 252,
		BuoyancyEffector2D				= 253,
		RelativeJoint2D					= 254,
		FixedJoint2D					= 255,
		FrictionJoint2D					= 256,
		TargetJoint2D					= 257,
		LightProbes						= 258,
		LightProbeProxyVolume			= 259,
		SampleClip						= 271,
		AudioMixerSnapshot				= 272,
		AudioMixerGroup					= 273,
		NScreenBridge					= 280,
		AssetBundleManifest				= 290,
		UnityAdsManager					= 292,
		RuntimeInitializeOnLoadManager	= 300,
		CloudWebServicesManager			= 301,
		UnityAnalyticsManager			= 303,
		CrashReportManager				= 304,
		PerformanceReportingManager		= 305,
		UnityConnectSettings			= 310,
#warning TODO: merge with AvatarMask
		AvatarMask1						= 319,
		PlayableDirector				= 320,
		VideoPlayer						= 328,
		VideoClip						= 329,
		ParticleSystemForceField		= 330,
		SpriteMask						= 331,
		WorldAnchor						= 362,
		OcclusionCullingData			= 363,

		// =====================================
		// Editor section
		// =====================================

		DataTemplate					= -1001,
		PrefabInstance					= 1001,
		EditorExtensionImpl				= 1002,
		AssetImporter					= 1003,
		AssetDatabase					= 1004,
		Mesh3DSImporter					= 1005,
		TextureImporter					= 1006,
		ShaderImporter					= 1007,
		ComputeShaderImporter			= 1008,
		AvatarMask						= 1011,
		AudioImporter					= 1020,
		HierarchyState					= 1026,
		GUIDSerializer					= 1027,
		AssetMetaData					= 1028,
		DefaultAsset					= 1029,
		DefaultImporter					= 1030,
		TextScriptImporter				= 1031,
		SceneAsset						= 1032,
		NativeFormatImporter			= 1034,
		MonoImporter					= 1035,
		AssetServerCache				= 1037,
		LibraryAssetImporter			= 1038,
		ModelImporter					= 1040,
		FBXImporter						= 1041,
		TrueTypeFontImporter			= 1042,
		MovieImporter					= 1044,
		EditorBuildSettings				= 1045,
		DDSImporter						= 1046,
		InspectorExpandedState			= 1048,
		AnnotationManager				= 1049,
		MonoAssemblyImporter			= -1050,
		PluginImporter					= 1050,
		EditorUserBuildSettings			= 1051,
		PVRImporter						= 1052,
		ASTCImporter					= 1053,
		KTXImporter						= 1054,
		IHVImageFormatImporter			= 1055,
		AnimatorStateTransition			= 1101,
		AnimatorState					= 1102,
		HumanTemplate					= 1105,
		AnimatorStateMachine			= 1107,
		PreviewAssetType				= 1108,
		AnimatorTransition				= 1109,
		SpeedTreeImporter				= 1110,
		AnimatorTransitionBase			= 1111,
		SubstanceImporter				= 1112,
		EnlightenSystemBuildParameters	= -1113,
		LightmapParameters				= 1113,
		LightmapSnapshot				= -1120,
		LightingDataAsset				= 1120,
		GISRaster						= 1121,
		GISRasterImporter				= 1122,
		CadImporter						= 1123,
		SketchUpImporter				= 1124,
		BuildReport						= 1125,
		PackedAssets					= 1126,
		VideoClipImporter				= 1127,
		/// <summary>
		/// ???
		/// </summary>
		ActivationLogComponent			= 2000,
		
		// =====================================
		// Custom section
		// =====================================

		@int							= 100000,
		@bool							= 100001,
		@float							= 100002,
		MonoObject						= 100003,
		Collision						= 100004,
		Vector3f						= 100005,
		RootMotionData					= 100006,
		Collision2D						= 100007,
		AudioMixerLiveUpdateFloat		= 100008,
		AudioMixerLiveUpdateBool		= 100009,
		Polygon2D						= 100010,
		@void							= 100011,

		// =====================================
		// New editor section
		// =====================================
		
		TilemapCollider2D									= 19719996,
		AssetImporterLog									= 41386430,
		VFXRenderer											= 73398921,
		SerializableManagedRefTestClass						= 76251197,
		Grid												= 156049354,
		Preset												= 181963792,
		EmptyObject											= 277625683,
		IConstraint											= 285090594,
		TestObjectWithSpecialLayoutOne						= 293259124,
		AssemblyDefinitionReferenceImporter					= 294290339,
		SiblingDerived										= 334799969,
		TestObjectWithSerializedMapStringNonAlignedStruct	= 342846651,
		SubDerived											= 367388927,
		AssetImportInProgressProxy							= 369655926,
		EditorProjectAccess									= 426301858,
		PrefabImporter										= 468431735,
		TestObjectWithSerializedArray						= 478637458,
		TestObjectWithSerializedAnimationCurve				= 478637459,
		TilemapRenderer										= 483693784,
		SpriteAtlasDatabase									= 638013454,
		CachedSpriteAtlasRuntimeData						= 644342135,
		RendererFake										= 646504946,
		AssemblyDefinitionReferenceAsset					= 662584278,
		BuiltAssetBundleInfoSet								= 668709126,
		SpriteAtlas											= 687078895,
		PlatformModuleSetup									= 877146078,
		AimConstraint										= 895512359,
		VFXManager											= 937362698,
		VisualEffectSubgraph								= 994735392,
		VisualEffectSubgraphOperator						= 994735403,
		VisualEffectSubgraphBlock							= 994735404,
		Prefab												= 1001480554,
		LocalizationImporter								= 1027052791,
		Derived												= 1091556383,
		PropertyModificationsTargetTestObject				= 1111377672,
		ReferencesArtifactGenerator							= 1114811875,
		AssemblyDefinitionAsset								= 1152215463,
		SceneVisibilityState								= 1154873562,
		LookAtConstraint									= 1183024399,
		MultiArtifactTestImporter							= 1223240404,
		GameObjectRecorder									= 1268269756,
		LightingDataAssetParent								= 1325145578,
		PresetManager										= 1386491679,
		TestObjectWithSpecialLayoutTwo						= 1392443030,
		StreamingManager									= 1403656975,
		LowerResBlitTexture									= 1480428607,
		StreamingController									= 1542919678,
		TestObjectVectorPairStringBool						= 1628831178,
		GridLayout											= 1742807556,
		AssemblyDefinitionImporter							= 1766753193,
		ParentConstraint									= 1773428102,
		FakeComponent										= 1803986026,
		PositionConstraint									= 1818360608,
		RotationConstraint									= 1818360609,
		ScaleConstraint										= 1818360610,
		Tilemap												= 1839735485,
		PackageManifest										= 1896753125,
		PackageManifestImporter								= 1896753126,
		TerrainLayer										= 1953259897,
		SpriteShapeRenderer									= 1971053207,
		NativeObjectType									= 1977754360,
		TestObjectWithSerializedMapStringBool				= 1981279845,
		SerializableManagedHost								= 1995898324,
		VisualEffectAsset									= 2058629509,
		VisualEffectImporter								= 2058629510,
		VisualEffectResource								= 2058629511,
		VisualEffectObject									= 2059678085,
		VisualEffect										= 2083052967,
		LocalizationAsset									= 2083778819,
		ScriptedImporter									= 2089858483,
		
		
	}
	
	public static class Dics
	{

/*		
public enum CmnKlas
{
AABB = 0,
AnimationClip = 5,
AnimationCurve = 19,
AnimationState = 34,
Array = 49,
Base = 0x37,
BitField = 60,
bitset = 69,
@bool = 76,
@char = 81,
ColorRGBA = 86,
Component = 96,
data = 106,
deque = 111,
@double = 117,
dynamic_array = 124,
FastPropertyName = 138,
first = 155,
@float = 161,
Font = 167,
GameObject = 172,
Generic\u3000Mono = 183,
GradientNEW = 196,
GUID = 208,
GUIStyle = 213,
@int = 222,
list = 226,
@long　long = 231,
map = 241,
Matrix4x4f = 245,
MdFour = 256,
MonoBehaviour = 263,
MonoScript = 0x115,
m_ByteSize = 288,
m_Curve = 299,
m_EditorClassIdentifier = 307,
m_EditorHideFlags = 331,
m_Enabled = 349,
m_ExtensionPtr = 359,
m_GameObject = 374,
m_Index = 387,
m_IsArray = 395,
m_IsStatic = 405,
m_MetaFlag = 416,
m_Name = 0x1AB,
m_ObjectHideFlags = 434,
m_PrefabInternal = 452,
m_PrefabParentObject = 469,
m_Script = 490,
m_StaticEditorFlags = 499,
m_Type = 519,
m_Version = 526,
Object = 536,
pair = 543,
PPtr＜Component＞ = 548,
PPtr＜GameObject＞ = 564,
PPtr＜Material＞ = 581,
PPtr＜MonoBehaviour＞ = 596,
PPtr＜MonoScript＞ = 616,
PPtr＜Object＞ = 633,
PPtr＜Prefab＞ = 646,
PPtr＜Sprite＞ = 659,
PPtr＜TextAsset＞ = 672,
PPtr＜Texture＞ = 688,
PPtr＜Texture2D＞ = 702,
PPtr＜Transform＞ = 718,
Prefab = 734,
Quaternionf = 741,
Rectf = 753,
RectInt = 759,
RectOffset = 767,
second = 778,
@set = 785,
@short = 789,
size = 795,
SInt16 = 800,
SInt32 = 807,
SInt64 = 814,
SInt8 = 821,
staticvector = 827,
@string = 840,
TextAsset = 847,
TextMesh = 857,
Texture = 866,
Texture2D = 874,
Transform = 884,
TypelessData = 894,
UInt16 = 907,
UInt32 = 914,
UInt64 = 921,
UInt8 = 928,
unsigned　int = 934,
unsigned　long　long = 947,
unsigned　short = 966,
vector = 981,
Vector2f = 988,
Vector3f = 997,
Vector4f = 1006,
m_ScriptingClassIdentifier = 1015,
Gradient = 1042,
Type\uFF0A = 1051,
int2_storage = 1057,
int3_storage = 1070,
BoundsInt = 1083,
m_CorrespondingSourceObject = 1093,
m_PrefabInstance = 1121,
m_PrefabAsset = 1138,
FileSize = 1152,
}
*/
		
		public static readonly Dictionary<int, string> CommonString = new Dictionary<int, string>
        {
            {0, "AABB"},
            {5, "AnimationClip"},
            {19, "AnimationCurve"},
            {34, "AnimationState"},
            {49, "Array"},
            {0x37, "Base"},
            {60, "BitField"},
            {69, "bitset"},
            {76, "bool"},
            {81, "char"},
            {86, "ColorRGBA"},
            {96, "Component"},
            {106, "data"},
            {111, "deque"},
            {117, "double"},
            {124, "dynamic_array"},
            {138, "FastPropertyName"},
            {155, "first"},
            {161, "float"},
            {167, "Font"},
            {172, "GameObject"},
            {183, "Generic Mono"},
            {196, "GradientNEW"},
            {208, "GUID"},
            {213, "GUIStyle"},
            {222, "int"},
            {226, "list"},
            {231, "long long"},
            {241, "map"},
            {245, "Matrix4x4f"},
            {256, "MdFour"},
            {263, "MonoBehaviour"},
            {0x115, "MonoScript"},
            {288, "m_ByteSize"},
            {299, "m_Curve"},
            {307, "m_EditorClassIdentifier"},
            {331, "m_EditorHideFlags"},
            {349, "m_Enabled"},
            {359, "m_ExtensionPtr"},
            {374, "m_GameObject"},
            {387, "m_Index"},
            {395, "m_IsArray"},
            {405, "m_IsStatic"},
            {416, "m_MetaFlag"},
            {0x1AB, "m_Name"},
            {434, "m_ObjectHideFlags"},
            {452, "m_PrefabInternal"},
            {469, "m_PrefabParentObject"},
            {490, "m_Script"},
            {499, "m_StaticEditorFlags"},
            {519, "m_Type"},
            {526, "m_Version"},
            {536, "Object"},
            {543, "pair"},
            {548, "PPtr<Component>"},
            {564, "PPtr<GameObject>"},
            {581, "PPtr<Material>"},
            {596, "PPtr<MonoBehaviour>"},
            {616, "PPtr<MonoScript>"},
            {633, "PPtr<Object>"},
            {646, "PPtr<Prefab>"},
            {659, "PPtr<Sprite>"},
            {672, "PPtr<TextAsset>"},
            {688, "PPtr<Texture>"},
            {702, "PPtr<Texture2D>"},
            {718, "PPtr<Transform>"},
            {734, "Prefab"},
            {741, "Quaternionf"},
            {753, "Rectf"},
            {759, "RectInt"},
            {767, "RectOffset"},
            {778, "second"},
            {785, "set"},
            {789, "short"},
            {795, "size"},
            {800, "SInt16"},
            {807, "SInt32"},
            {814, "SInt64"},
            {821, "SInt8"},
            {827, "staticvector"},
            {840, "string"},
            {847, "TextAsset"},
            {857, "TextMesh"},
            {866, "Texture"},
            {874, "Texture2D"},
            {884, "Transform"},
            {894, "TypelessData"},
            {907, "UInt16"},
            {914, "UInt32"},
            {921, "UInt64"},
            {928, "UInt8"},
            {934, "unsigned int"},
            {947, "unsigned long long"},
            {966, "unsigned short"},
            {981, "vector"},
            {988, "Vector2f"},
            {997, "Vector3f"},
            {1006, "Vector4f"},
            {1015, "m_ScriptingClassIdentifier"},
            {1042, "Gradient"},
            {1051, "Type*"},
            {1057, "int2_storage"},
            {1070, "int3_storage"},
            {1083, "BoundsInt"},
            {1093, "m_CorrespondingSourceObject"},
            {1121, "m_PrefabInstance"},
            {1138, "m_PrefabAsset"},
            {1152, "FileSize"}
        };
		
		public static readonly Dictionary<int, string> UserString = new Dictionary<int, string>();
		
		public static int UserStrIdx=0;
		
		public static int PutUserStr(string ustr)
		{
			foreach(var kp in UserString)
			{
				if(ustr==kp.Value)
				{
					//Console.WriteLine("reuse: "+ustr);
					return kp.Key;
				}
					
			}
			
			UserStrIdx--;
			UserString[UserStrIdx]=ustr;
			return UserStrIdx;
		}
		
		public static string GetString(int key)
		{
			if(key<0)
				return UserString[key];
			else
				return CommonString[key];
		}
	}
	
	#endregion
	
	
	public class Light : uObject
	{
		/*
		public override void Load(byte[] buf)
		{
			UnityEngine.Debug.Log("Dis is Light");
		}
		*/
		public override void Load(byte[] buf)
		{
			UnityEngine.Debug.Log("Dis is Light");
		}
	}
	
	public class Texture2D : uObject
	{
		public override void Load(byte[] buf)
		{
			UnityEngine.Debug.Log("Dis is TEx2d");
			
		}
	}
}