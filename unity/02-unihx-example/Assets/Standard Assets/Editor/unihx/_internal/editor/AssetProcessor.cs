
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace unihx._internal.editor{
	public  class AssetProcessor : global::UnityEditor.AssetPostprocessor {
		public    AssetProcessor() : base(){
			unchecked {
			}
			#line default
		}
		
		
		public static   void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths){
			unchecked {
				#line 19 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
				global::Array<object> sources = new global::Array<object>(new object[]{});
				global::Array<object> deleted = new global::Array<object>(new object[]{});
				bool refresh = false;
				{
					#line 22 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
					int _g = 0;
					#line 22 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
					while (( _g < ( importedAssets as global::System.Array ).Length )){
						#line 22 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
						string str = importedAssets[_g];
						#line 22 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
						 ++ _g;
						#line 24 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
						if (str.EndsWith(".hx")) {
							#line 25 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
							sources.push(str);
						}
						
					}
					
				}
				
				#line 27 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
				{
					#line 27 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
					int _g1 = 0;
					#line 27 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
					while (( _g1 < ( movedAssets as global::System.Array ).Length )){
						#line 27 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
						string str1 = movedAssets[_g1];
						#line 27 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
						 ++ _g1;
						#line 29 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
						if (str1.EndsWith(".hx")) {
							#line 30 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
							sources.push(str1);
						}
						
					}
					
				}
				
				#line 33 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
				{
					#line 33 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
					int _g2 = 0;
					#line 33 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
					while (( _g2 < ( movedFromAssetPaths as global::System.Array ).Length )){
						#line 33 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
						string d = movedFromAssetPaths[_g2];
						#line 33 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
						 ++ _g2;
						#line 35 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
						if (d.EndsWith(".hx")) {
							#line 37 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
							deleted.push(d);
						}
						
					}
					
				}
				
				#line 40 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
				{
					#line 40 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
					int _g3 = 0;
					#line 40 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
					while (( _g3 < ( deletedAssets as global::System.Array ).Length )){
						#line 40 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
						string d1 = deletedAssets[_g3];
						#line 40 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
						 ++ _g3;
						#line 42 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
						if (d1.EndsWith(".hx")) {
							#line 44 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
							deleted.push(d1);
						}
						
					}
					
				}
				
				#line 48 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
				{
					#line 48 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
					int _g4 = 0;
					#line 48 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
					while (( _g4 < deleted.length )){
						#line 48 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
						string d2 = global::haxe.lang.Runtime.toString(deleted[_g4]);
						#line 48 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
						 ++ _g4;
						#line 51 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
						string path = global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.io.Path.directory(d2), "/hx-compiled/"), global::haxe.lang.StringExt.substr(global::haxe.io.Path.withoutDirectory(d2), 0, new global::haxe.lang.Null<int>(-2, true))), "cs");
						if (global::sys.FileSystem.exists(path)) {
							#line 54 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
							global::sys.FileSystem.deleteFile(path);
							if (global::sys.FileSystem.exists(global::haxe.lang.Runtime.concat(path, ".meta"))) {
								#line 56 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
								global::sys.FileSystem.deleteFile(global::haxe.lang.Runtime.concat(path, ".meta"));
							}
							
							#line 57 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
							if (( global::sys.FileSystem.readDirectory(global::haxe.lang.Runtime.concat(global::haxe.io.Path.directory(d2), "/hx-compiled")).length == 0 )) {
								#line 58 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
								global::sys.FileSystem.deleteDirectory(global::haxe.lang.Runtime.concat(global::haxe.io.Path.directory(d2), "/hx-compiled"));
							}
							
							#line 59 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
							refresh = true;
						}
						
					}
					
				}
				
				#line 62 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
				if (( sources.length > 0 )) {
					#line 64 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
					refresh = true;
					global::unihx._internal.editor.HaxePropertiesData comp = global::HaxeProperties.props();
					bool success = comp.compile(new global::Array<object>(new object[]{"--cwd", global::haxe.lang.Runtime.concat(global::Sys.getCwd(), "/Assets"), "build.hxml", "--macro", "unihx._internal.Compiler.compile()"}));
				}
				
				#line 68 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
				if (refresh) {
					#line 70 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\AssetProcessor.hx"
					global::UnityEditor.AssetDatabase.Refresh();
				}
				
			}
			#line default
		}
		
		
	}
}


