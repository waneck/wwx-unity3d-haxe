
#pragma warning disable 109, 114, 219, 429, 168, 162
public  class WrappedValue_Helper__ : global::haxe.lang.HxObject {
	public    WrappedValue_Helper__(global::haxe.lang.EmptyObject empty){
		unchecked {
			#line 585 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public    WrappedValue_Helper__(){
		unchecked {
			#line 585 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
			global::WrappedValue_Helper__.__hx_ctor__WrappedValue_Helper__(this);
		}
		#line default
	}
	
	
	public static   void __hx_ctor__WrappedValue_Helper__(global::WrappedValue_Helper__ __temp_me12){
		unchecked {
			#line 585 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public static   global::WrappedValue editorHelper(global::WrappedValue current, global::UnityEngine.GUIContent label, global::UnityEngine.GUILayoutOption[] opts){
		unchecked {
			#line 545 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
			int popup = default(int);
			#line 545 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
			if (( current == default(global::WrappedValue) )) {
				#line 545 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				popup = 0;
			}
			 else {
				#line 545 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				popup = ( global::Type.enumIndex(current) + 1 );
			}
			
			#line 586 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
			global::UnityEngine.GUIContent[] guiContent = default(global::UnityEngine.GUIContent[]);
			#line 586 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
			{
				#line 608 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				global::UnityEngine.GUIContent[] opts1 = new global::UnityEngine.GUIContent[((int) (3) )];
				#line 611 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				opts1[0] = new global::UnityEngine.GUIContent(((string) ("null") ), ((string) ("Null") ));
				#line 611 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				opts1[1] = new global::UnityEngine.GUIContent(((string) ("int") ), ((string) ("Int value") ));
				#line 611 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				opts1[2] = new global::UnityEngine.GUIContent(((string) ("string") ), ((string) ("String Value") ));
				#line 613 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				guiContent = opts1;
			}
			
			#line 586 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
			int[] values = default(int[]);
			#line 586 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
			{
				#line 608 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				int[] opts2 = new int[((int) (3) )];
				#line 611 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				opts2[0] = 1;
				#line 611 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				opts2[1] = 2;
				#line 611 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				opts2[2] = 3;
				#line 613 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				values = opts2;
			}
			
			#line 548 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
			int p2 = global::UnityEditor.EditorGUILayout.IntPopup(((global::UnityEngine.GUIContent) (label) ), ((int) (popup) ), ((global::UnityEngine.GUIContent[]) (guiContent) ), ((int[]) (values) ), ((global::UnityEngine.GUILayoutOption[]) (opts) ));
			#line 586 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
			switch (p2){
				case 1:
				{
					#line 586 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
					return global::WrappedValue.WNull;
				}
				
				
				case 2:
				{
					#line 498 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
					int @value = default(int);
					global::UnityEditor.EditorGUILayout.BeginHorizontal(((global::UnityEngine.GUILayoutOption[]) (default(global::UnityEngine.GUILayoutOption[])) ));
					global::UnityEditor.EditorGUILayout.Space();
					global::UnityEditor.EditorGUILayout.BeginVertical(((global::UnityEngine.GUILayoutOption[]) (default(global::UnityEngine.GUILayoutOption[])) ));
					#line 586 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
					if (( ! (global::haxe.lang.Runtime.eq(current, default(object))) )) {
						#line 503 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						switch (global::Type.enumIndex(current)){
							case 1:
							{
								#line 503 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
								int value_arg = ((int) (global::haxe.lang.Runtime.toInt(current.@params[0])) );
								#line 506 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
								@value = value_arg;
								#line 586 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
								break;
							}
							
							
							default:
							{
								#line 508 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
								object __temp_expr47 = default(object);
								#line 508 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
								break;
							}
							
						}
						
					}
					 else {
						#line 508 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						object __temp_expr46 = default(object);
					}
					
					#line 510 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
					int value__changed = @value;
					#line 393 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
					value__changed = global::UnityEditor.EditorGUILayout.IntField(((global::UnityEngine.GUIContent) (new global::UnityEngine.GUIContent(((string) ("value") ))) ), ((int) (value__changed) ), ((global::UnityEngine.GUILayoutOption[]) (default(global::UnityEngine.GUILayoutOption[])) ));
					#line 527 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
					global::UnityEditor.EditorGUILayout.EndVertical();
					global::UnityEditor.EditorGUILayout.EndHorizontal();
					#line 533 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
					if (( ( popup != 2 ) ||  ! (global::Type.enumEq<int>(@value, value__changed))  )) {
						#line 586 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return global::WrappedValue.WInt(value__changed);
					}
					 else {
						#line 536 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return current;
					}
					
				}
				
				
				case 3:
				{
					#line 498 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
					string value1 = default(string);
					global::UnityEditor.EditorGUILayout.BeginHorizontal(((global::UnityEngine.GUILayoutOption[]) (default(global::UnityEngine.GUILayoutOption[])) ));
					global::UnityEditor.EditorGUILayout.Space();
					global::UnityEditor.EditorGUILayout.BeginVertical(((global::UnityEngine.GUILayoutOption[]) (default(global::UnityEngine.GUILayoutOption[])) ));
					#line 586 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
					if (( ! (global::haxe.lang.Runtime.eq(current, default(object))) )) {
						#line 503 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						switch (global::Type.enumIndex(current)){
							case 2:
							{
								#line 503 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
								string value_arg1 = global::haxe.lang.Runtime.toString(current.@params[0]);
								#line 506 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
								value1 = value_arg1;
								#line 586 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
								break;
							}
							
							
							default:
							{
								#line 508 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
								object __temp_expr49 = default(object);
								#line 508 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
								break;
							}
							
						}
						
					}
					 else {
						#line 508 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						object __temp_expr48 = default(object);
					}
					
					#line 510 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
					string value__changed1 = value1;
					#line 422 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
					value__changed1 = global::UnityEditor.EditorGUILayout.TextField(((global::UnityEngine.GUIContent) (new global::UnityEngine.GUIContent(((string) ("value") ))) ), ((string) (value__changed1) ), ((global::UnityEngine.GUILayoutOption[]) (default(global::UnityEngine.GUILayoutOption[])) ));
					#line 527 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
					global::UnityEditor.EditorGUILayout.EndVertical();
					global::UnityEditor.EditorGUILayout.EndHorizontal();
					#line 533 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
					if (( ( popup != 3 ) ||  ! (global::Type.enumEq<object>(value1, value__changed1))  )) {
						#line 586 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return global::WrappedValue.WString(value__changed1);
					}
					 else {
						#line 536 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return current;
					}
					
				}
				
				
				default:
				{
					#line 543 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
					return default(global::WrappedValue);
				}
				
			}
			
		}
		#line default
	}
	
	
	public static  new object __hx_createEmpty(){
		unchecked {
			#line 585 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
			return new global::WrappedValue_Helper__(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
		}
		#line default
	}
	
	
	public static  new object __hx_create(global::Array arr){
		unchecked {
			#line 585 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
			return new global::WrappedValue_Helper__();
		}
		#line default
	}
	
	
}


