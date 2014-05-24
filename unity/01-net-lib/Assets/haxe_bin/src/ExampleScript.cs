
#pragma warning disable 109, 114, 219, 429, 168, 162
public  class ExampleScript : global::UnityEngine.MonoBehaviour, global::haxe.lang.IHxObject {
	public    ExampleScript(global::haxe.lang.EmptyObject empty) : base(){
		unchecked {
		}
		#line default
	}
	
	
	public    ExampleScript() : base(){
		unchecked {
		}
		#line default
	}
	
	
	public static   object __hx_createEmpty(){
		unchecked {
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			return new global::ExampleScript(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
		}
		#line default
	}
	
	
	public static   object __hx_create(global::Array arr){
		unchecked {
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			return new global::ExampleScript();
		}
		#line default
	}
	
	
	public  string stringProp;
	
	public  int[] arrayProp;
	
	public  global::UnityEngine.Vector3 vectorProp;
	
	public virtual   bool __hx_deleteField(string field, int hash){
		unchecked {
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			return false;
		}
		#line default
	}
	
	
	public virtual   object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck){
		unchecked {
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			if (isCheck) {
				#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
				return global::haxe.lang.Runtime.undefined;
			}
			 else {
				#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
				if (throwErrors) {
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					throw global::haxe.lang.HaxeException.wrap("Field not found.");
				}
				 else {
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return default(object);
				}
				
			}
			
		}
		#line default
	}
	
	
	public virtual   double __hx_lookupField_f(string field, int hash, bool throwErrors){
		unchecked {
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			if (throwErrors) {
				#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
				throw global::haxe.lang.HaxeException.wrap("Field not found or incompatible field type.");
			}
			 else {
				#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
				return default(double);
			}
			
		}
		#line default
	}
	
	
	public virtual   object __hx_lookupSetField(string field, int hash, object @value){
		unchecked {
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing.");
		}
		#line default
	}
	
	
	public virtual   double __hx_lookupSetField_f(string field, int hash, double @value){
		unchecked {
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing or incompatible type.");
		}
		#line default
	}
	
	
	public virtual   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
		unchecked {
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			switch (hash){
				default:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return this.__hx_lookupSetField_f(field, hash, @value);
				}
				
			}
			
		}
		#line default
	}
	
	
	public virtual   object __hx_setField(string field, int hash, object @value, bool handleProperties){
		unchecked {
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			switch (hash){
				case 1224700491:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					( this as global::UnityEngine.Object ).name = global::haxe.lang.Runtime.toString(@value);
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return @value;
				}
				
				
				case 1575675685:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					( this as global::UnityEngine.Object ).hideFlags = ((global::UnityEngine.HideFlags) (@value) );
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return @value;
				}
				
				
				case 373703110:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					( this as global::UnityEngine.Component ).active = global::haxe.lang.Runtime.toBool(@value);
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return @value;
				}
				
				
				case 5790298:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					( this as global::UnityEngine.Component ).tag = global::haxe.lang.Runtime.toString(@value);
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return @value;
				}
				
				
				case 2117141633:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					( this as global::UnityEngine.Behaviour ).enabled = global::haxe.lang.Runtime.toBool(@value);
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return @value;
				}
				
				
				case 896046654:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					( this as global::UnityEngine.MonoBehaviour ).useGUILayout = global::haxe.lang.Runtime.toBool(@value);
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return @value;
				}
				
				
				case 206619142:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					this.vectorProp = ((global::UnityEngine.Vector3) (@value) );
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return @value;
				}
				
				
				case 332440028:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					this.arrayProp = ((int[]) (@value) );
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return @value;
				}
				
				
				case 2086361364:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					this.stringProp = global::haxe.lang.Runtime.toString(@value);
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return @value;
				}
				
				
				default:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return this.__hx_lookupSetField(field, hash, @value);
				}
				
			}
			
		}
		#line default
	}
	
	
	public virtual   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
		unchecked {
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			switch (hash){
				case 304123084:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("ToString") ), ((int) (304123084) ))) );
				}
				
				
				case 1683266824:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("set_hideFlags") ), ((int) (1683266824) ))) );
				}
				
				
				case 525253372:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_hideFlags") ), ((int) (525253372) ))) );
				}
				
				
				case 1998030664:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("set_name") ), ((int) (1998030664) ))) );
				}
				
				
				case 1220160980:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_name") ), ((int) (1220160980) ))) );
				}
				
				
				case 276486854:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("GetInstanceID") ), ((int) (276486854) ))) );
				}
				
				
				case 1224700491:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((string) (this.name) );
				}
				
				
				case 1575675685:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::UnityEngine.HideFlags) (this.hideFlags) );
				}
				
				
				case 2134927590:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("BroadcastMessage") ), ((int) (2134927590) ))) );
				}
				
				
				case 139469119:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("SendMessage") ), ((int) (139469119) ))) );
				}
				
				
				case 294420221:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("SendMessageUpwards") ), ((int) (294420221) ))) );
				}
				
				
				case 89600725:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("CompareTag") ), ((int) (89600725) ))) );
				}
				
				
				case 432976893:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("set_tag") ), ((int) (432976893) ))) );
				}
				
				
				case 650978033:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_tag") ), ((int) (650978033) ))) );
				}
				
				
				case 172707843:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("set_active") ), ((int) (172707843) ))) );
				}
				
				
				case 114143631:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_active") ), ((int) (114143631) ))) );
				}
				
				
				case 2122408236:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("GetComponents") ), ((int) (2122408236) ))) );
				}
				
				
				case 967979664:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("GetComponentsInChildren") ), ((int) (967979664) ))) );
				}
				
				
				case 1328964235:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("GetComponentInChildren") ), ((int) (1328964235) ))) );
				}
				
				
				case 1723652455:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("GetComponent") ), ((int) (1723652455) ))) );
				}
				
				
				case 1303048346:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_gameObject") ), ((int) (1303048346) ))) );
				}
				
				
				case 67314334:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_particleSystem") ), ((int) (67314334) ))) );
				}
				
				
				case 709878495:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_particleEmitter") ), ((int) (709878495) ))) );
				}
				
				
				case 795555816:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_hingeJoint") ), ((int) (795555816) ))) );
				}
				
				
				case 1214826575:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_collider2D") ), ((int) (1214826575) ))) );
				}
				
				
				case 2129630013:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_collider") ), ((int) (2129630013) ))) );
				}
				
				
				case 505642985:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_guiTexture") ), ((int) (505642985) ))) );
				}
				
				
				case 93808074:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_guiElement") ), ((int) (93808074) ))) );
				}
				
				
				case 456247754:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_networkView") ), ((int) (456247754) ))) );
				}
				
				
				case 902054111:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_guiText") ), ((int) (902054111) ))) );
				}
				
				
				case 1797903661:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_audio") ), ((int) (1797903661) ))) );
				}
				
				
				case 1744140620:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_renderer") ), ((int) (1744140620) ))) );
				}
				
				
				case 1539891518:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_constantForce") ), ((int) (1539891518) ))) );
				}
				
				
				case 211337947:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_animation") ), ((int) (211337947) ))) );
				}
				
				
				case 950398253:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_light") ), ((int) (950398253) ))) );
				}
				
				
				case 672380526:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_camera") ), ((int) (672380526) ))) );
				}
				
				
				case 1888889206:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_rigidbody2D") ), ((int) (1888889206) ))) );
				}
				
				
				case 845057188:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_rigidbody") ), ((int) (845057188) ))) );
				}
				
				
				case 116851011:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_transform") ), ((int) (116851011) ))) );
				}
				
				
				case 1167273324:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::UnityEngine.Transform) (this.transform) );
				}
				
				
				case 1895479501:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::UnityEngine.Rigidbody) (this.rigidbody) );
				}
				
				
				case 800354783:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::UnityEngine.Rigidbody2D) (this.rigidbody2D) );
				}
				
				
				case 931940005:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::UnityEngine.Camera) (this.camera) );
				}
				
				
				case 1962709206:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::UnityEngine.Light) (this.light) );
				}
				
				
				case 1261760260:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::UnityEngine.Animation) (this.animation) );
				}
				
				
				case 1431885287:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::UnityEngine.ConstantForce) (this.constantForce) );
				}
				
				
				case 853263683:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::UnityEngine.Renderer) (this.renderer) );
				}
				
				
				case 662730966:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::UnityEngine.AudioSource) (this.audio) );
				}
				
				
				case 801759432:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::UnityEngine.GUIText) (this.guiText) );
				}
				
				
				case 1515196979:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::UnityEngine.NetworkView) (this.networkView) );
				}
				
				
				case 262266241:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::UnityEngine.GUIElement) (this.guiElement) );
				}
				
				
				case 674101152:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::UnityEngine.GUITexture) (this.guiTexture) );
				}
				
				
				case 1238753076:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::UnityEngine.Collider) (this.collider) );
				}
				
				
				case 1383284742:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::UnityEngine.Collider2D) (this.collider2D) );
				}
				
				
				case 964013983:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::UnityEngine.HingeJoint) (this.hingeJoint) );
				}
				
				
				case 524620744:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::UnityEngine.ParticleEmitter) (this.particleEmitter) );
				}
				
				
				case 1751728597:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::UnityEngine.ParticleSystem) (this.particleSystem) );
				}
				
				
				case 1471506513:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::UnityEngine.GameObject) (this.gameObject) );
				}
				
				
				case 373703110:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return global::haxe.lang.Runtime.toBool(this.active);
				}
				
				
				case 5790298:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((string) (this.tag) );
				}
				
				
				case 244870052:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("set_enabled") ), ((int) (244870052) ))) );
				}
				
				
				case 69952664:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_enabled") ), ((int) (69952664) ))) );
				}
				
				
				case 2117141633:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return global::haxe.lang.Runtime.toBool(this.enabled);
				}
				
				
				case 273248315:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("set_useGUILayout") ), ((int) (273248315) ))) );
				}
				
				
				case 973570759:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_useGUILayout") ), ((int) (973570759) ))) );
				}
				
				
				case 1856815770:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("StopAllCoroutines") ), ((int) (1856815770) ))) );
				}
				
				
				case 2084823382:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("StopCoroutine") ), ((int) (2084823382) ))) );
				}
				
				
				case 832859768:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("StartCoroutine_Auto") ), ((int) (832859768) ))) );
				}
				
				
				case 987108662:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("StartCoroutine") ), ((int) (987108662) ))) );
				}
				
				
				case 602588383:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("IsInvoking") ), ((int) (602588383) ))) );
				}
				
				
				case 757431474:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("CancelInvoke") ), ((int) (757431474) ))) );
				}
				
				
				case 1641152943:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("InvokeRepeating") ), ((int) (1641152943) ))) );
				}
				
				
				case 1416948632:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("Invoke") ), ((int) (1416948632) ))) );
				}
				
				
				case 896046654:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return global::haxe.lang.Runtime.toBool(this.useGUILayout);
				}
				
				
				case 206619142:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return this.vectorProp;
				}
				
				
				case 332440028:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return this.arrayProp;
				}
				
				
				case 2086361364:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return this.stringProp;
				}
				
				
				default:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return this.__hx_lookupField(field, hash, throwErrors, isCheck);
				}
				
			}
			
		}
		#line default
	}
	
	
	public virtual   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties){
		unchecked {
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			switch (hash){
				default:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return this.__hx_lookupField_f(field, hash, throwErrors);
				}
				
			}
			
		}
		#line default
	}
	
	
	public virtual   object __hx_invokeField(string field, int hash, global::Array dynargs){
		unchecked {
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			switch (hash){
				case 1416948632:case 1641152943:case 757431474:case 602588383:case 987108662:case 832859768:case 2084823382:case 1856815770:case 973570759:case 273248315:case 69952664:case 244870052:case 116851011:case 845057188:case 1888889206:case 672380526:case 950398253:case 211337947:case 1539891518:case 1744140620:case 1797903661:case 902054111:case 456247754:case 93808074:case 505642985:case 2129630013:case 1214826575:case 795555816:case 709878495:case 67314334:case 1303048346:case 1723652455:case 1328964235:case 967979664:case 2122408236:case 114143631:case 172707843:case 650978033:case 432976893:case 89600725:case 294420221:case 139469119:case 2134927590:case 276486854:case 1220160980:case 1998030664:case 525253372:case 1683266824:case 304123084:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
				}
				
				
				default:
				{
					#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
					return ((global::haxe.lang.Function) (this.__hx_getField(field, hash, true, false, false)) ).__hx_invokeDynamic(dynargs);
				}
				
			}
			
		}
		#line default
	}
	
	
	public virtual   void __hx_getFields(global::Array<object> baseArr){
		unchecked {
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("name");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("hideFlags");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("transform");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("rigidbody");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("rigidbody2D");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("camera");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("light");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("animation");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("constantForce");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("renderer");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("audio");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("guiText");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("networkView");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("guiElement");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("guiTexture");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("collider");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("collider2D");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("hingeJoint");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("particleEmitter");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("particleSystem");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("gameObject");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("active");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("tag");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("enabled");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("useGUILayout");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("vectorProp");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("arrayProp");
			#line 4 "/var/dev/proj/wwx-pres/unity/01-net-lib/Assets/haxe_src/ExampleScript.hx"
			baseArr.push("stringProp");
		}
		#line default
	}
	
	
}


