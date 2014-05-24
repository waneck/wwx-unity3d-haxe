
#pragma warning disable 109, 114, 219, 429, 168, 162
public  class HaxeProperties : global::UnityEditor.EditorWindow, global::haxe.lang.IHxObject {
	public    HaxeProperties(global::haxe.lang.EmptyObject empty) : base(){
		unchecked {
		}
		#line default
	}
	
	
	public    HaxeProperties() : base(){
		unchecked {
		}
		#line default
	}
	
	
	[UnityEditor.MenuItem("Window/Haxe Properties")]
	public static   void showWindow(){
		unchecked {
			#line 18 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			global::UnityEditor.EditorWindow.GetWindow(((global::System.Type) (typeof(global::HaxeProperties)) ));
		}
		#line default
	}
	
	
	public static   global::unihx._internal.editor.HaxePropertiesData props(){
		unchecked {
			#line 60 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			return global::unihx._internal.editor.HaxePropertiesData.@get();
		}
		#line default
	}
	
	
	public static   object __hx_createEmpty(){
		unchecked {
			#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			return new global::HaxeProperties(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
		}
		#line default
	}
	
	
	public static   object __hx_create(global::Array arr){
		unchecked {
			#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			return new global::HaxeProperties();
		}
		#line default
	}
	
	
	public  global::UnityEngine.Vector2 scroll;
	
	public virtual   void OnEnable(){
		unchecked {
			#line 23 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			global::haxe.Log.trace.__hx_invoke2_o(default(double), "enable", default(double), new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{302979532, 1547539107, 1648581351}), new global::Array<object>(new object[]{"OnEnable", "unihx._internal.editor.HaxeProperties", "HaxeProperties.hx"}), new global::Array<int>(new int[]{1981972957}), new global::Array<double>(new double[]{((double) (23) )})));
			global::HaxeProperties.props();
		}
		#line default
	}
	
	
	public virtual   void OnDisable(){
		unchecked {
			#line 29 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			global::haxe.Log.trace.__hx_invoke2_o(default(double), "disable", default(double), new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{302979532, 1547539107, 1648581351}), new global::Array<object>(new object[]{"OnDisable", "unihx._internal.editor.HaxeProperties", "HaxeProperties.hx"}), new global::Array<int>(new int[]{1981972957}), new global::Array<double>(new double[]{((double) (29) )})));
			global::HaxeProperties.props().close();
		}
		#line default
	}
	
	
	public virtual   void OnGUI(){
		unchecked {
			#line 35 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			global::UnityEngine.GUILayoutOption[] arr = new global::UnityEngine.GUILayoutOption[((int) (1) )];
			arr[0] = global::UnityEngine.GUILayout.MaxHeight(((float) (300) ));
			#line 38 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			global::UnityEngine.GUILayout.BeginVertical(((global::UnityEngine.GUILayoutOption[]) (arr) ));
			this.scroll = global::UnityEngine.GUILayout.BeginScrollView(((global::UnityEngine.Vector2) (this.scroll) ), ((global::UnityEngine.GUILayoutOption[]) (new global::UnityEngine.GUILayoutOption[((int) (0) )]) ));
			global::HaxeProperties.props().OnGUI();
			global::UnityEngine.GUILayout.EndScrollView();
			if (global::UnityEngine.GUILayout.Button(((string) ("Save") ), ((global::UnityEngine.GUILayoutOption[]) (default(global::UnityEngine.GUILayoutOption[])) ))) {
				#line 44 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				global::HaxeProperties.props().save();
			}
			
			#line 46 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			if (global::UnityEngine.GUILayout.Button(((string) ("Reload") ), ((global::UnityEngine.GUILayoutOption[]) (default(global::UnityEngine.GUILayoutOption[])) ))) {
				#line 48 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				global::HaxeProperties.props().reload();
			}
			
			#line 50 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			if (global::UnityEngine.GUILayout.Button(((string) ("Force recompile") ), ((global::UnityEngine.GUILayoutOption[]) (default(global::UnityEngine.GUILayoutOption[])) ))) {
				#line 52 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				global::HaxeProperties.props().compile(new global::Array<object>(new object[]{"--cwd", global::haxe.lang.Runtime.concat(global::Sys.getCwd(), "/Assets"), "params.hxml", "--macro", "unihx._internal.Compiler.compile()"}));
				global::UnityEditor.AssetDatabase.Refresh();
			}
			
			#line 55 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			global::UnityEngine.GUILayout.EndVertical();
		}
		#line default
	}
	
	
	public virtual   bool __hx_deleteField(string field, int hash){
		unchecked {
			#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			return false;
		}
		#line default
	}
	
	
	public virtual   object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck){
		unchecked {
			#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			if (isCheck) {
				#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				return global::haxe.lang.Runtime.undefined;
			}
			 else {
				#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				if (throwErrors) {
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					throw global::haxe.lang.HaxeException.wrap("Field not found.");
				}
				 else {
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return default(object);
				}
				
			}
			
		}
		#line default
	}
	
	
	public virtual   double __hx_lookupField_f(string field, int hash, bool throwErrors){
		unchecked {
			#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			if (throwErrors) {
				#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				throw global::haxe.lang.HaxeException.wrap("Field not found or incompatible field type.");
			}
			 else {
				#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				return default(double);
			}
			
		}
		#line default
	}
	
	
	public virtual   object __hx_lookupSetField(string field, int hash, object @value){
		unchecked {
			#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing.");
		}
		#line default
	}
	
	
	public virtual   double __hx_lookupSetField_f(string field, int hash, double @value){
		unchecked {
			#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing or incompatible type.");
		}
		#line default
	}
	
	
	public virtual   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
		unchecked {
			#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			switch (hash){
				case 852810505:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					( this as global::UnityEditor.EditorWindow ).depthBufferBits = ((int) (@value) );
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return @value;
				}
				
				
				case 152520334:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					( this as global::UnityEditor.EditorWindow ).antiAlias = ((int) (@value) );
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return @value;
				}
				
				
				default:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return this.__hx_lookupSetField_f(field, hash, @value);
				}
				
			}
			
		}
		#line default
	}
	
	
	public virtual   object __hx_setField(string field, int hash, object @value, bool handleProperties){
		unchecked {
			#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			switch (hash){
				case 1224700491:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					( this as global::UnityEngine.Object ).name = global::haxe.lang.Runtime.toString(@value);
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return @value;
				}
				
				
				case 1575675685:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					( this as global::UnityEngine.Object ).hideFlags = ((global::UnityEngine.HideFlags) (@value) );
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return @value;
				}
				
				
				case 159864755:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					( this as global::UnityEditor.EditorWindow ).wantsMouseMove = global::haxe.lang.Runtime.toBool(@value);
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return @value;
				}
				
				
				case 1165440001:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					( this as global::UnityEditor.EditorWindow ).autoRepaintOnSceneChange = global::haxe.lang.Runtime.toBool(@value);
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return @value;
				}
				
				
				case 2128678424:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					( this as global::UnityEditor.EditorWindow ).maximized = global::haxe.lang.Runtime.toBool(@value);
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return @value;
				}
				
				
				case 1029508979:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					( this as global::UnityEditor.EditorWindow ).minSize = ((global::UnityEngine.Vector2) (@value) );
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return @value;
				}
				
				
				case 1283717509:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					( this as global::UnityEditor.EditorWindow ).maxSize = ((global::UnityEngine.Vector2) (@value) );
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return @value;
				}
				
				
				case 272307608:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					( this as global::UnityEditor.EditorWindow ).title = global::haxe.lang.Runtime.toString(@value);
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return @value;
				}
				
				
				case 852810505:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					( this as global::UnityEditor.EditorWindow ).depthBufferBits = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return @value;
				}
				
				
				case 152520334:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					( this as global::UnityEditor.EditorWindow ).antiAlias = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return @value;
				}
				
				
				case 1257939113:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					( this as global::UnityEditor.EditorWindow ).position = ((global::UnityEngine.Rect) (@value) );
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return @value;
				}
				
				
				case 1197791245:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					this.scroll = ((global::UnityEngine.Vector2) (@value) );
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return @value;
				}
				
				
				default:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return this.__hx_lookupSetField(field, hash, @value);
				}
				
			}
			
		}
		#line default
	}
	
	
	public virtual   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
		unchecked {
			#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			switch (hash){
				case 304123084:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("ToString") ), ((int) (304123084) ))) );
				}
				
				
				case 1683266824:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("set_hideFlags") ), ((int) (1683266824) ))) );
				}
				
				
				case 525253372:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_hideFlags") ), ((int) (525253372) ))) );
				}
				
				
				case 1998030664:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("set_name") ), ((int) (1998030664) ))) );
				}
				
				
				case 1220160980:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_name") ), ((int) (1220160980) ))) );
				}
				
				
				case 276486854:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("GetInstanceID") ), ((int) (276486854) ))) );
				}
				
				
				case 1224700491:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((string) (this.name) );
				}
				
				
				case 1575675685:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::UnityEngine.HideFlags) (this.hideFlags) );
				}
				
				
				case 1102476592:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("SetDirty") ), ((int) (1102476592) ))) );
				}
				
				
				case 1476879762:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("SendEvent") ), ((int) (1476879762) ))) );
				}
				
				
				case 353204262:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("set_position") ), ((int) (353204262) ))) );
				}
				
				
				case 1332402:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_position") ), ((int) (1332402) ))) );
				}
				
				
				case 260111473:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("set_antiAlias") ), ((int) (260111473) ))) );
				}
				
				
				case 1249581669:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_antiAlias") ), ((int) (1249581669) ))) );
				}
				
				
				case 2054987052:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("set_depthBufferBits") ), ((int) (2054987052) ))) );
				}
				
				
				case 1038068256:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_depthBufferBits") ), ((int) (1038068256) ))) );
				}
				
				
				case 926244347:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("set_title") ), ((int) (926244347) ))) );
				}
				
				
				case 1407480303:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_title") ), ((int) (1407480303) ))) );
				}
				
				
				case 1558929576:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("set_maxSize") ), ((int) (1558929576) ))) );
				}
				
				
				case 1384012188:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_maxSize") ), ((int) (1384012188) ))) );
				}
				
				
				case 1304721046:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("set_minSize") ), ((int) (1304721046) ))) );
				}
				
				
				case 1129803658:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_minSize") ), ((int) (1129803658) ))) );
				}
				
				
				case 1899639531:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("Repaint") ), ((int) (1899639531) ))) );
				}
				
				
				case 1536198552:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("Close") ), ((int) (1536198552) ))) );
				}
				
				
				case 1321596727:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("ShowAuxWindow") ), ((int) (1321596727) ))) );
				}
				
				
				case 925630749:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("Show") ), ((int) (925630749) ))) );
				}
				
				
				case 886988480:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("ShowAsDropDown") ), ((int) (886988480) ))) );
				}
				
				
				case 382488527:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("ShowPopup") ), ((int) (382488527) ))) );
				}
				
				
				case 1615420367:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("ShowUtility") ), ((int) (1615420367) ))) );
				}
				
				
				case 397856696:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("Focus") ), ((int) (397856696) ))) );
				}
				
				
				case 1224073528:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("ShowTab") ), ((int) (1224073528) ))) );
				}
				
				
				case 88785915:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("set_maximized") ), ((int) (88785915) ))) );
				}
				
				
				case 1078256111:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_maximized") ), ((int) (1078256111) ))) );
				}
				
				
				case 167089534:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("set_autoRepaintOnSceneChange") ), ((int) (167089534) ))) );
				}
				
				
				case 113986058:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_autoRepaintOnSceneChange") ), ((int) (113986058) ))) );
				}
				
				
				case 1539529071:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("RemoveNotification") ), ((int) (1539529071) ))) );
				}
				
				
				case 345308072:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("ShowNotification") ), ((int) (345308072) ))) );
				}
				
				
				case 30436080:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("set_wantsMouseMove") ), ((int) (30436080) ))) );
				}
				
				
				case 622934140:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_wantsMouseMove") ), ((int) (622934140) ))) );
				}
				
				
				case 88606728:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("EndWindows") ), ((int) (88606728) ))) );
				}
				
				
				case 2005397370:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("BeginWindows") ), ((int) (2005397370) ))) );
				}
				
				
				case 159864755:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return global::haxe.lang.Runtime.toBool(this.wantsMouseMove);
				}
				
				
				case 1165440001:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return global::haxe.lang.Runtime.toBool(this.autoRepaintOnSceneChange);
				}
				
				
				case 2128678424:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return global::haxe.lang.Runtime.toBool(this.maximized);
				}
				
				
				case 1029508979:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::UnityEngine.Vector2) (this.minSize) );
				}
				
				
				case 1283717509:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::UnityEngine.Vector2) (this.maxSize) );
				}
				
				
				case 272307608:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((string) (this.title) );
				}
				
				
				case 852810505:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((int) (this.depthBufferBits) );
				}
				
				
				case 152520334:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((int) (this.antiAlias) );
				}
				
				
				case 1257939113:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::UnityEngine.Rect) (this.position) );
				}
				
				
				case 1167292028:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("OnGUI") ), ((int) (1167292028) ))) );
				}
				
				
				case 718668393:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("OnDisable") ), ((int) (718668393) ))) );
				}
				
				
				case 837181730:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("OnEnable") ), ((int) (837181730) ))) );
				}
				
				
				case 1197791245:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return this.scroll;
				}
				
				
				default:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return this.__hx_lookupField(field, hash, throwErrors, isCheck);
				}
				
			}
			
		}
		#line default
	}
	
	
	public virtual   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties){
		unchecked {
			#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			switch (hash){
				case 852810505:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((double) (((int) (this.depthBufferBits) )) );
				}
				
				
				case 152520334:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((double) (((int) (this.antiAlias) )) );
				}
				
				
				default:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return this.__hx_lookupField_f(field, hash, throwErrors);
				}
				
			}
			
		}
		#line default
	}
	
	
	public virtual   object __hx_invokeField(string field, int hash, global::Array dynargs){
		unchecked {
			#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			switch (hash){
				case 2005397370:case 88606728:case 622934140:case 30436080:case 345308072:case 1539529071:case 113986058:case 167089534:case 1078256111:case 88785915:case 1224073528:case 397856696:case 1615420367:case 382488527:case 886988480:case 925630749:case 1321596727:case 1536198552:case 1899639531:case 1129803658:case 1304721046:case 1384012188:case 1558929576:case 1407480303:case 926244347:case 1038068256:case 2054987052:case 1249581669:case 260111473:case 1332402:case 353204262:case 1476879762:case 1102476592:case 276486854:case 1220160980:case 1998030664:case 525253372:case 1683266824:case 304123084:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
				}
				
				
				case 1167292028:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					this.OnGUI();
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					break;
				}
				
				
				case 718668393:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					this.OnDisable();
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					break;
				}
				
				
				case 837181730:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					this.OnEnable();
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					break;
				}
				
				
				default:
				{
					#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return ((global::haxe.lang.Function) (this.__hx_getField(field, hash, true, false, false)) ).__hx_invokeDynamic(dynargs);
				}
				
			}
			
			#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			return default(object);
		}
		#line default
	}
	
	
	public virtual   void __hx_getFields(global::Array<object> baseArr){
		unchecked {
			#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			baseArr.push("name");
			#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			baseArr.push("hideFlags");
			#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			baseArr.push("wantsMouseMove");
			#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			baseArr.push("autoRepaintOnSceneChange");
			#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			baseArr.push("maximized");
			#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			baseArr.push("minSize");
			#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			baseArr.push("maxSize");
			#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			baseArr.push("title");
			#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			baseArr.push("depthBufferBits");
			#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			baseArr.push("antiAlias");
			#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			baseArr.push("position");
			#line 12 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			baseArr.push("scroll");
		}
		#line default
	}
	
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace unihx._internal.editor{
	public  class HaxePropertiesData : global::haxe.lang.HxObject, global::unihx.inspector.InspectorBuild {
		public    HaxePropertiesData(global::haxe.lang.EmptyObject empty){
			unchecked {
				#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    HaxePropertiesData(){
			unchecked {
				#line 208 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				global::unihx._internal.editor.HaxePropertiesData.__hx_ctor_unihx__internal_editor_HaxePropertiesData(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_unihx__internal_editor_HaxePropertiesData(global::unihx._internal.editor.HaxePropertiesData __temp_me40){
			unchecked {
				#line 209 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static  global::unihx._internal.editor.HaxePropertiesData current;
		
		public static   global::unihx._internal.editor.HaxePropertiesData @get(){
			unchecked {
				#line 93 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				if (( global::unihx._internal.editor.HaxePropertiesData.current == default(global::unihx._internal.editor.HaxePropertiesData) )) {
					#line 94 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					return global::unihx._internal.editor.HaxePropertiesData.current = new global::unihx._internal.editor.HaxePropertiesData().reload();
				}
				
				#line 95 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				return global::unihx._internal.editor.HaxePropertiesData.current;
			}
			#line default
		}
		
		
		public static   int availablePort(){
			unchecked {
				#line 214 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				global::System.Net.Sockets.TcpListener l = new global::System.Net.Sockets.TcpListener(((global::System.Net.IPAddress) (global::System.Net.IPAddress.Loopback) ), ((int) (0) ));
				l.Start();
				int port = (((global::System.Net.IPEndPoint) (l.LocalEndpoint) )).Port;
				l.Stop();
				return port;
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				return new global::unihx._internal.editor.HaxePropertiesData(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr){
			unchecked {
				#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				return new global::unihx._internal.editor.HaxePropertiesData();
			}
			#line default
		}
		
		
		public  global::unihx._internal.editor.Comp compilation;
		
		public  bool verbose;
		
		public  string extraParams;
		
		public  global::unihx._internal.editor.HaxeCompiler compiler;
		
		public virtual   global::unihx._internal.editor.HaxePropertiesData reload(){
			unchecked {
				#line 100 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				if (global::sys.FileSystem.exists("Assets/build.hxml")) {
					#line 102 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					this.reloadFrom(global::sys.io.File.read("Assets/build.hxml", default(global::haxe.lang.Null<bool>)));
				}
				 else {
					#line 104 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					this.save();
				}
				
				#line 106 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				return this;
			}
			#line default
		}
		
		
		public virtual   bool compile(global::Array<object> args){
			unchecked {
				#line 111 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				if (( this.compiler == default(global::unihx._internal.editor.HaxeCompiler) )) {
					#line 112 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					this.reload();
				}
				
				#line 113 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				if (( this.compiler == default(global::unihx._internal.editor.HaxeCompiler) )) {
					#line 114 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					this.compiler = new global::unihx._internal.editor.HaxeCompiler(((global::unihx._internal.editor.Comp) (this.compilation) ));
				}
				
				#line 116 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				return this.compiler.compile(args, default(global::haxe.lang.Null<bool>));
			}
			#line default
		}
		
		
		public virtual   void close(){
			unchecked {
				#line 121 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				global::unihx._internal.editor.HaxePropertiesData.current = default(global::unihx._internal.editor.HaxePropertiesData);
				if (( this.compiler != default(global::unihx._internal.editor.HaxeCompiler) )) {
					#line 123 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					this.compiler.close();
				}
				
				#line 124 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				this.compiler = default(global::unihx._internal.editor.HaxeCompiler);
			}
			#line default
		}
		
		
		public virtual   string getSaveContents(){
			unchecked {
				#line 129 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				global::StringBuf b = new global::StringBuf();
				if (( string.Equals(this.extraParams, default(string)) || string.Equals(this.extraParams, "") )) {
					#line 131 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					b.b.Append(((object) ("# Add your own compiler parameters here\n\n") ));
				}
				
				#line 132 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				{
					#line 132 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					global::unihx._internal.editor.Comp _g = this.compilation;
					#line 132 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					switch (global::Type.enumIndex(_g)){
						case 2:
						{
							#line 132 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
							int p = ((int) (global::haxe.lang.Runtime.toInt(_g.@params[0])) );
							#line 134 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
							{
								#line 135 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
								if (( p < 1024 )) {
									#line 136 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
									p = global::unihx._internal.editor.HaxePropertiesData.availablePort();
								}
								
								#line 137 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
								b.b.Append(((object) (global::Std.@string(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("params.hxml\n#--connect ", global::haxe.lang.Runtime.toString(p)), "\n"))) ));
							}
							
							#line 134 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
							break;
						}
						
						
						case 1:
						{
							#line 139 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
							b.b.Append(((object) ("params.hxml\n") ));
							#line 139 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
							break;
						}
						
						
						case 0:
						{
							#line 140 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
							{
							}
							
							#line 140 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
							break;
						}
						
						
					}
					
				}
				
				#line 142 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				if (this.verbose) {
					#line 143 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					b.b.Append(((object) ("#verbose\n") ));
				}
				
				#line 144 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				b.b.Append(((object) ("\n") ));
				if ( ! (string.Equals(this.extraParams, default(string))) ) {
					#line 146 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					b.b.Append(((object) (global::Std.@string(this.extraParams)) ));
				}
				
				#line 147 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				return b.toString();
			}
			#line default
		}
		
		
		public virtual   void save(){
			unchecked {
				#line 152 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				global::sys.io.FileOutput w = global::sys.io.File.write("Assets/build.hxml", default(global::haxe.lang.Null<bool>));
				w.writeString(this.getSaveContents());
				w.close();
				#line 156 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				if (( ( this.compiler == default(global::unihx._internal.editor.HaxeCompiler) ) ||  ! (global::Type.enumEq<object>(this.compiler.props, this.compilation))  )) {
					#line 158 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					if (( this.compiler != default(global::unihx._internal.editor.HaxeCompiler) )) {
						#line 159 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						this.compiler.close();
					}
					
					#line 160 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					this.compiler = new global::unihx._internal.editor.HaxeCompiler(((global::unihx._internal.editor.Comp) (this.compilation) ));
				}
				
			}
			#line default
		}
		
		
		public virtual   void reloadFrom(global::haxe.io.Input i){
			unchecked {
				#line 166 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				global::unihx._internal.editor.Comp comp = global::unihx._internal.editor.Comp.DontCompile;
				global::StringBuf buf = new global::StringBuf();
				this.verbose = false;
				#line 170 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				try {
					#line 171 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					global::EReg regex = new global::EReg(((string) ("[ \t]+") ), ((string) ("g") ));
					while (true){
						#line 174 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						string ln = default(string);
						#line 174 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						{
							#line 174 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
							string s = i.readLine();
							#line 174 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
							ln = s.Trim();
						}
						
						#line 175 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						global::Array<object> cmd = regex.split(ln);
						{
							#line 176 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
							string _g = global::haxe.lang.Runtime.toString(cmd[0]);
							#line 176 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
							switch (_g){
								case "--connect":case "#--connect":
								{
									#line 179 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
									global::Array<object> portCmd = global::haxe.lang.StringExt.split(global::haxe.lang.Runtime.toString(cmd[1]), ":");
									global::haxe.lang.Null<int> port = default(global::haxe.lang.Null<int>);
									#line 180 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
									if (( portCmd.length == 1 )) {
										#line 181 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
										port = global::Std.parseInt(global::haxe.lang.Runtime.toString(portCmd[0]));
									}
									 else {
										#line 183 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
										port = global::Std.parseInt(global::haxe.lang.Runtime.toString(portCmd[1]));
									}
									
									#line 184 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
									comp = global::unihx._internal.editor.Comp.CompilationServer(port.@value);
									#line 178 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
									break;
								}
								
								
								case "#verbose":
								{
									#line 186 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
									this.verbose = true;
									#line 186 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
									break;
								}
								
								
								case "params.hxml":
								{
									#line 188 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
									if (( comp == global::unihx._internal.editor.Comp.DontCompile )) {
										#line 189 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
										comp = global::unihx._internal.editor.Comp.Compile;
									}
									
									#line 188 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
									break;
								}
								
								
								default:
								{
									#line 191 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
									buf.b.Append(((object) (global::Std.@string(ln)) ));
									buf.b.Append(((object) ("\n") ));
									#line 190 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
									break;
								}
								
							}
							
						}
						
					}
					
				}
				catch (global::System.Exception __temp_catchallException60){
					#line 170 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					global::haxe.lang.Exceptions.exception = __temp_catchallException60;
					#line 196 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					object __temp_catchall61 = __temp_catchallException60;
					#line 196 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					if (( __temp_catchall61 is global::haxe.lang.HaxeException )) {
						#line 196 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						__temp_catchall61 = ((global::haxe.lang.HaxeException) (__temp_catchallException60) ).obj;
					}
					
					#line 196 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					if (( __temp_catchall61 is global::haxe.io.Eof )) {
						#line 196 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						global::haxe.io.Eof e = ((global::haxe.io.Eof) (__temp_catchall61) );
						#line 196 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						{
							#line 196 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
							{
							}
							
						}
						
					}
					 else {
						#line 196 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						throw;
					}
					
				}
				
				
				#line 197 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				if (( ( this.compilation == default(global::unihx._internal.editor.Comp) ) ||  ! (global::Type.enumEq<object>(this.compilation, comp))  )) {
					#line 199 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					if (( this.compiler != default(global::unihx._internal.editor.HaxeCompiler) )) {
						#line 200 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						this.compiler.close();
					}
					
					#line 201 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					this.compiler = new global::unihx._internal.editor.HaxeCompiler(((global::unihx._internal.editor.Comp) (comp) ));
				}
				
				#line 204 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				this.compilation = comp;
				{
					#line 205 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					string s1 = buf.toString();
					#line 205 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					this.extraParams = s1.Trim();
				}
				
			}
			#line default
		}
		
		
		public virtual   void OnGUI(){
			unchecked {
				#line 69 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				this.compilation = global::unihx._internal.editor.Comp_Helper__.editorHelper(this.compilation, new global::UnityEngine.GUIContent(((string) ("compilation") ), ((string) ("Choose how will Haxe classes be compiled") )), default(global::UnityEngine.GUILayoutOption[]));
				#line 71 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				global::UnityEditor.EditorGUILayout.Space();
				#line 73 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				this.verbose = global::UnityEditor.EditorGUILayout.Toggle(((global::UnityEngine.GUIContent) (new global::UnityEngine.GUIContent(((string) ("verbose") ))) ), global::haxe.lang.Runtime.toBool(this.verbose), ((global::UnityEngine.GUILayoutOption[]) (default(global::UnityEngine.GUILayoutOption[])) ));
				#line 79 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				global::UnityEditor.EditorGUILayout.LabelField(((global::UnityEngine.GUIContent) (new global::UnityEngine.GUIContent(((string) ("Extra parameters") ), ((string) ("Extra Haxe parameters from build.hxml") ))) ), ((global::UnityEngine.GUILayoutOption[]) (default(global::UnityEngine.GUILayoutOption[])) ));
				#line 85 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				global::UnityEngine.GUILayoutOption[] __temp_stmt62 = default(global::UnityEngine.GUILayoutOption[]);
				#line 85 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				{
					#line 85 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					global::UnityEngine.GUILayoutOption[] opts = new global::UnityEngine.GUILayoutOption[((int) (1) )];
					#line 85 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					opts[0] = global::UnityEngine.GUILayout.MinHeight(((float) (200.0) ));
					#line 85 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					__temp_stmt62 = opts;
				}
				
				#line 85 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				this.extraParams = global::UnityEditor.EditorGUILayout.TextArea(((string) (this.extraParams) ), ((global::UnityEngine.GUILayoutOption[]) (__temp_stmt62) ));
			}
			#line default
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				switch (hash){
					case 2110889887:
					{
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						this.compiler = ((global::unihx._internal.editor.HaxeCompiler) (@value) );
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						return @value;
					}
					
					
					case 1815369206:
					{
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						this.extraParams = global::haxe.lang.Runtime.toString(@value);
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						return @value;
					}
					
					
					case 1908004738:
					{
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						this.verbose = global::haxe.lang.Runtime.toBool(@value);
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						return @value;
					}
					
					
					case 1893521091:
					{
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						this.compilation = ((global::unihx._internal.editor.Comp) (@value) );
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						return @value;
					}
					
					
					default:
					{
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				switch (hash){
					case 1167292028:
					{
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("OnGUI") ), ((int) (1167292028) ))) );
					}
					
					
					case 248137059:
					{
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("reloadFrom") ), ((int) (248137059) ))) );
					}
					
					
					case 1280150333:
					{
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("save") ), ((int) (1280150333) ))) );
					}
					
					
					case 1687594797:
					{
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getSaveContents") ), ((int) (1687594797) ))) );
					}
					
					
					case 1214453688:
					{
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("close") ), ((int) (1214453688) ))) );
					}
					
					
					case 57615731:
					{
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("compile") ), ((int) (57615731) ))) );
					}
					
					
					case 64967513:
					{
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("reload") ), ((int) (64967513) ))) );
					}
					
					
					case 2110889887:
					{
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						return this.compiler;
					}
					
					
					case 1815369206:
					{
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						return this.extraParams;
					}
					
					
					case 1908004738:
					{
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						return this.verbose;
					}
					
					
					case 1893521091:
					{
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						return this.compilation;
					}
					
					
					default:
					{
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::Array dynargs){
			unchecked {
				#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				switch (hash){
					case 1167292028:
					{
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						this.OnGUI();
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						break;
					}
					
					
					case 248137059:
					{
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						this.reloadFrom(((global::haxe.io.Input) (dynargs[0]) ));
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						break;
					}
					
					
					case 1280150333:
					{
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						this.save();
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						break;
					}
					
					
					case 1687594797:
					{
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						return this.getSaveContents();
					}
					
					
					case 1214453688:
					{
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						this.close();
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						break;
					}
					
					
					case 57615731:
					{
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						return this.compile(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (dynargs[0]) ))) ));
					}
					
					
					case 64967513:
					{
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						return this.reload();
					}
					
					
					default:
					{
						#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				return default(object);
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr){
			unchecked {
				#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				baseArr.push("compiler");
				#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				baseArr.push("extraParams");
				#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				baseArr.push("verbose");
				#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				baseArr.push("compilation");
				#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				{
					#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace unihx._internal.editor{
	public  class Comp : global::haxe.lang.Enum {
		static Comp() {
			#line 222 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			global::unihx._internal.editor.Comp.constructs = new global::Array<object>(new object[]{"DontCompile", "Compile", "CompilationServer"});
			#line 227 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			global::unihx._internal.editor.Comp.DontCompile = new global::unihx._internal.editor.Comp(((int) (0) ), ((global::Array<object>) (new global::Array<object>(new object[]{})) ));
			#line 231 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
			global::unihx._internal.editor.Comp.Compile = new global::unihx._internal.editor.Comp(((int) (1) ), ((global::Array<object>) (new global::Array<object>(new object[]{})) ));
		}
		public    Comp(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
			#line default
		}
		
		
		public    Comp(int index, global::Array<object> @params) : base(index, @params){
			unchecked {
			}
			#line default
		}
		
		
		public static  global::Array<object> constructs;
		
		public static  global::unihx._internal.editor.Comp DontCompile;
		
		public static  global::unihx._internal.editor.Comp Compile;
		
		public static   global::unihx._internal.editor.Comp CompilationServer(int port){
			unchecked {
				#line 235 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				return new global::unihx._internal.editor.Comp(((int) (2) ), ((global::Array<object>) (new global::Array<object>(new object[]{port})) ));
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				#line 222 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				return new global::unihx._internal.editor.Comp(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr){
			unchecked {
				#line 222 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeProperties.hx"
				return new global::unihx._internal.editor.Comp(((int) (global::haxe.lang.Runtime.toInt(arr[0])) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (arr[1]) ))) ));
			}
			#line default
		}
		
		
	}
}


