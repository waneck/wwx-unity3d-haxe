
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace editor{
	[UnityEditor.CustomEditor(typeof(Test))]
	public  class Test_Helper__ : global::UnityEditor.Editor, global::haxe.lang.IHxObject {
		public    Test_Helper__(global::haxe.lang.EmptyObject empty) : base(){
			unchecked {
			}
			#line default
		}
		
		
		public    Test_Helper__() : base(){
			unchecked {
			}
			#line default
		}
		
		
		public static   object __hx_createEmpty(){
			unchecked {
				#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				return new global::editor.Test_Helper__(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static   object __hx_create(global::Array arr){
			unchecked {
				#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				return new global::editor.Test_Helper__();
			}
			#line default
		}
		
		
		public override   void OnInspectorGUI(){
			unchecked {
				#line 6 "Z:\\var\\dev\\proj\\wwx-pres\\unity\\02-unihx-example\\Assets\\Test.hx"
				((global::Test) (( this as global::UnityEditor.Editor ).target) ).haxeEnum = global::WrappedValue_Helper__.editorHelper(((global::Test) (( this as global::UnityEditor.Editor ).target) ).haxeEnum, new global::UnityEngine.GUIContent(((string) ("haxe enum") )), default(global::UnityEngine.GUILayoutOption[]));
				#line 168 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				global::UnityEditor.EditorUtility.SetDirty(((global::UnityEngine.Object) (( this as global::UnityEditor.Editor ).target) ));
			}
			#line default
		}
		
		
		public virtual   bool __hx_deleteField(string field, int hash){
			unchecked {
				#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				return false;
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck){
			unchecked {
				#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				if (isCheck) {
					#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
					return global::haxe.lang.Runtime.undefined;
				}
				 else {
					#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
					if (throwErrors) {
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						throw global::haxe.lang.HaxeException.wrap("Field not found.");
					}
					 else {
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return default(object);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   double __hx_lookupField_f(string field, int hash, bool throwErrors){
			unchecked {
				#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				if (throwErrors) {
					#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
					throw global::haxe.lang.HaxeException.wrap("Field not found or incompatible field type.");
				}
				 else {
					#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
					return default(double);
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_lookupSetField(string field, int hash, object @value){
			unchecked {
				#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing.");
			}
			#line default
		}
		
		
		public virtual   double __hx_lookupSetField_f(string field, int hash, double @value){
			unchecked {
				#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing or incompatible type.");
			}
			#line default
		}
		
		
		public virtual   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				switch (hash){
					default:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return this.__hx_lookupSetField_f(field, hash, @value);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				switch (hash){
					case 1224700491:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						( this as global::UnityEngine.Object ).name = global::haxe.lang.Runtime.toString(@value);
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return @value;
					}
					
					
					case 1575675685:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						( this as global::UnityEngine.Object ).hideFlags = ((global::UnityEngine.HideFlags) (@value) );
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return @value;
					}
					
					
					default:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return this.__hx_lookupSetField(field, hash, @value);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				switch (hash){
					case 304123084:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("ToString") ), ((int) (304123084) ))) );
					}
					
					
					case 1683266824:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("set_hideFlags") ), ((int) (1683266824) ))) );
					}
					
					
					case 525253372:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_hideFlags") ), ((int) (525253372) ))) );
					}
					
					
					case 1998030664:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("set_name") ), ((int) (1998030664) ))) );
					}
					
					
					case 1220160980:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_name") ), ((int) (1220160980) ))) );
					}
					
					
					case 276486854:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("GetInstanceID") ), ((int) (276486854) ))) );
					}
					
					
					case 1224700491:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((string) (this.name) );
					}
					
					
					case 1575675685:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::UnityEngine.HideFlags) (this.hideFlags) );
					}
					
					
					case 1102476592:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("SetDirty") ), ((int) (1102476592) ))) );
					}
					
					
					case 1045792757:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("GetInfoString") ), ((int) (1045792757) ))) );
					}
					
					
					case 1051779724:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("OnPreviewSettings") ), ((int) (1051779724) ))) );
					}
					
					
					case 835143702:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("OnInteractivePreviewGUI") ), ((int) (835143702) ))) );
					}
					
					
					case 1577512306:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("OnPreviewGUI") ), ((int) (1577512306) ))) );
					}
					
					
					case 1988410276:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("RenderStaticPreview") ), ((int) (1988410276) ))) );
					}
					
					
					case 1483924998:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("GetPreviewTitle") ), ((int) (1483924998) ))) );
					}
					
					
					case 536348461:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("HasPreviewGUI") ), ((int) (536348461) ))) );
					}
					
					
					case 1899639531:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("Repaint") ), ((int) (1899639531) ))) );
					}
					
					
					case 1292390425:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("RequiresConstantRepaint") ), ((int) (1292390425) ))) );
					}
					
					
					case 516234554:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("DrawDefaultInspector") ), ((int) (516234554) ))) );
					}
					
					
					case 1938282860:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_serializedObject") ), ((int) (1938282860) ))) );
					}
					
					
					case 241325081:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_targets") ), ((int) (241325081) ))) );
					}
					
					
					case 2004116250:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("get_target") ), ((int) (2004116250) ))) );
					}
					
					
					case 2076696651:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("UseDefaultMargins") ), ((int) (2076696651) ))) );
					}
					
					
					case 2043302319:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("OnHeaderGUI") ), ((int) (2043302319) ))) );
					}
					
					
					case 896829649:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("DrawHeader") ), ((int) (896829649) ))) );
					}
					
					
					case 116192081:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::UnityEngine.Object) (this.target) );
					}
					
					
					case 141030402:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::UnityEngine.Object[]) (this.targets) );
					}
					
					
					case 1427993699:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::UnityEditor.SerializedObject) (this.serializedObject) );
					}
					
					
					case 311523491:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("OnInspectorGUI") ), ((int) (311523491) ))) );
					}
					
					
					default:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return this.__hx_lookupField(field, hash, throwErrors, isCheck);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties){
			unchecked {
				#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				switch (hash){
					default:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return this.__hx_lookupField_f(field, hash, throwErrors);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   object __hx_invokeField(string field, int hash, global::Array dynargs){
			unchecked {
				#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				switch (hash){
					case 311523491:case 896829649:case 2043302319:case 2076696651:case 2004116250:case 241325081:case 1938282860:case 516234554:case 1292390425:case 1899639531:case 536348461:case 1483924998:case 1988410276:case 1577512306:case 835143702:case 1051779724:case 1045792757:case 1102476592:case 276486854:case 1220160980:case 1998030664:case 525253372:case 1683266824:case 304123084:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					default:
					{
						#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return ((global::haxe.lang.Function) (this.__hx_getField(field, hash, true, false, false)) ).__hx_invokeDynamic(dynargs);
					}
					
				}
				
			}
			#line default
		}
		
		
		public virtual   void __hx_getFields(global::Array<object> baseArr){
			unchecked {
				#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				baseArr.push("name");
				#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				baseArr.push("hideFlags");
				#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				baseArr.push("target");
				#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				baseArr.push("targets");
				#line 163 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				baseArr.push("serializedObject");
			}
			#line default
		}
		
		
	}
}


