
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace unihx._internal.editor{
	public  class Comp_Helper__ : global::haxe.lang.HxObject {
		public    Comp_Helper__(global::haxe.lang.EmptyObject empty){
			unchecked {
				#line 585 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    Comp_Helper__(){
			unchecked {
				#line 585 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				global::unihx._internal.editor.Comp_Helper__.__hx_ctor_unihx__internal_editor_Comp_Helper__(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_unihx__internal_editor_Comp_Helper__(global::unihx._internal.editor.Comp_Helper__ __temp_me37){
			unchecked {
				#line 585 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static   global::unihx._internal.editor.Comp editorHelper(global::unihx._internal.editor.Comp current, global::UnityEngine.GUIContent label, global::UnityEngine.GUILayoutOption[] opts){
			unchecked {
				#line 545 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				int popup = default(int);
				#line 545 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				if (( current == default(global::unihx._internal.editor.Comp) )) {
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
					opts1[0] = new global::UnityEngine.GUIContent(((string) ("Don\'t compile") ), ((string) ("") ));
					#line 611 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
					opts1[1] = new global::UnityEngine.GUIContent(((string) ("Use standard Haxe compiler") ), ((string) ("") ));
					#line 611 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
					opts1[2] = new global::UnityEngine.GUIContent(((string) ("Use compilation server") ), ((string) ("") ));
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
						return global::unihx._internal.editor.Comp.DontCompile;
					}
					
					
					case 2:
					{
						#line 586 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return global::unihx._internal.editor.Comp.Compile;
					}
					
					
					case 3:
					{
						#line 498 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						int port = default(int);
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
									int port_arg = ((int) (global::haxe.lang.Runtime.toInt(current.@params[0])) );
									#line 506 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
									port = port_arg;
									#line 586 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
									break;
								}
								
								
								default:
								{
									#line 508 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
									object __temp_expr58 = default(object);
									#line 508 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
									break;
								}
								
							}
							
						}
						 else {
							#line 508 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
							object __temp_expr57 = default(object);
						}
						
						#line 510 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						int port__changed = port;
						#line 393 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						port__changed = global::UnityEditor.EditorGUILayout.IntField(((global::UnityEngine.GUIContent) (new global::UnityEngine.GUIContent(((string) ("port") ))) ), ((int) (port__changed) ), ((global::UnityEngine.GUILayoutOption[]) (default(global::UnityEngine.GUILayoutOption[])) ));
						#line 527 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						global::UnityEditor.EditorGUILayout.EndVertical();
						global::UnityEditor.EditorGUILayout.EndHorizontal();
						#line 533 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						if (( ( popup != 3 ) ||  ! (global::Type.enumEq<int>(port, port__changed))  )) {
							#line 586 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
							return global::unihx._internal.editor.Comp.CompilationServer(port__changed);
						}
						 else {
							#line 536 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
							return current;
						}
						
					}
					
					
					default:
					{
						#line 543 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
						return default(global::unihx._internal.editor.Comp);
					}
					
				}
				
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				#line 585 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				return new global::unihx._internal.editor.Comp_Helper__(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr){
			unchecked {
				#line 585 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Macro.hx"
				return new global::unihx._internal.editor.Comp_Helper__();
			}
			#line default
		}
		
		
	}
}


