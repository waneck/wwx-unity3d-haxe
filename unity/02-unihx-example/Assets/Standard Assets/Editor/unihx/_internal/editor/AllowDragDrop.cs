
#pragma warning disable 109, 114, 219, 429, 168, 162
[UnityEditor.CustomEditor(typeof(UnityEngine.Transform))]
[UnityEditor.CanEditMultipleObjects]
public  class AllowDragDrop : global::UnityEditor.Editor {
	public    AllowDragDrop() : base(){
		unchecked {
		}
		#line default
	}
	
	
	
	
	public virtual   void OnEnable(){
		unchecked {
			#line 17 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
			( this as global::UnityEditor.Editor ).Repaint();
		}
		#line default
	}
	
	
	public   global::UnityEngine.Transform get__target(){
		unchecked {
			#line 22 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
			return ((global::UnityEngine.Transform) (( this as global::UnityEditor.Editor ).target) );
		}
		#line default
	}
	
	
	public override   void OnInspectorGUI(){
		unchecked {
			#line 27 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
			global::UnityEngine.Object[] obj = global::UnityEditor.DragAndDrop.objectReferences;
			if (( ( obj == default(global::UnityEngine.Object[]) ) || ( ( obj as global::System.Array ).Length == 0 ) )) {
				#line 29 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
				return ;
			}
			
			#line 30 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
			{
				#line 30 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
				global::UnityEngine.EventType _g = global::UnityEngine.Event.current.type;
				#line 30 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
				switch (global::Type.enumIndex(_g)){
					case 9:
					{
						#line 32 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
						bool __temp_stmt49 = default(bool);
						#line 32 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
						{
							#line 32 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
							string s = global::UnityEditor.AssetDatabase.GetAssetPath(((global::UnityEngine.Object) (global::UnityEditor.DragAndDrop.objectReferences[0]) ));
							#line 32 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
							__temp_stmt49 = s.EndsWith(".hx");
						}
						
						#line 32 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
						if (__temp_stmt49) {
							#line 33 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
							global::UnityEditor.DragAndDrop.visualMode = ((global::UnityEditor.DragAndDropVisualMode) (global::UnityEditor.DragAndDropVisualMode.Link) );
							global::UnityEngine.Event.current.Use();
						}
						 else {
							#line 43 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
							base.OnInspectorGUI();
						}
						
						#line 32 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
						break;
					}
					
					
					case 11:
					{
						#line 32 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
						bool __temp_stmt50 = default(bool);
						#line 32 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
						{
							#line 32 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
							string s = global::UnityEditor.AssetDatabase.GetAssetPath(((global::UnityEngine.Object) (global::UnityEditor.DragAndDrop.objectReferences[0]) ));
							#line 32 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
							__temp_stmt50 = s.EndsWith(".hx");
						}
						
						#line 32 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
						if (__temp_stmt50) {
							#line 33 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
							global::UnityEditor.DragAndDrop.visualMode = ((global::UnityEditor.DragAndDropVisualMode) (global::UnityEditor.DragAndDropVisualMode.Link) );
							global::UnityEngine.Event.current.Use();
						}
						 else {
							#line 43 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
							base.OnInspectorGUI();
						}
						
						#line 32 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
						break;
					}
					
					
					case 10:
					{
						#line 35 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
						bool __temp_stmt51 = default(bool);
						#line 35 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
						{
							#line 35 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
							string s1 = global::UnityEditor.AssetDatabase.GetAssetPath(((global::UnityEngine.Object) (global::UnityEditor.DragAndDrop.objectReferences[0]) ));
							#line 35 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
							__temp_stmt51 = s1.EndsWith(".hx");
						}
						
						#line 35 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
						if (__temp_stmt51) {
							#line 36 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
							global::UnityEditor.DragAndDrop.visualMode = ((global::UnityEditor.DragAndDropVisualMode) (global::UnityEditor.DragAndDropVisualMode.Link) );
							global::UnityEditor.DragAndDrop.AcceptDrag();
							global::UnityEngine.Event.current.Use();
							global::UnityEngine.Component ret = ( ((global::UnityEngine.Transform) (( this as global::UnityEditor.Editor ).target) ) as global::UnityEngine.Component ).gameObject.AddComponent(((string) (global::UnityEditor.DragAndDrop.objectReferences[0].name) ));
							if (( ret == default(global::UnityEngine.Component) )) {
								#line 41 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
								global::UnityEditor.EditorUtility.DisplayDialog(((string) ("Can\'t add script") ), ((string) (global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Can\'t add script behaviour \"", global::UnityEditor.DragAndDrop.objectReferences[0].name), "\"")) ), ((string) ("OK") ));
							}
							
						}
						 else {
							#line 43 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
							base.OnInspectorGUI();
						}
						
						#line 35 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
						break;
					}
					
					
					default:
					{
						#line 43 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
						base.OnInspectorGUI();
						#line 43 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AllowDragDrop.hx"
						break;
					}
					
				}
				
			}
			
		}
		#line default
	}
	
	
}


