
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace sys{
	public  class FileSystem : global::haxe.lang.HxObject {
		public    FileSystem(global::haxe.lang.EmptyObject empty){
			unchecked {
				#line 29 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\FileSystem.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    FileSystem(){
			unchecked {
				#line 29 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\FileSystem.hx"
				global::sys.FileSystem.__hx_ctor_sys_FileSystem(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_sys_FileSystem(global::sys.FileSystem __temp_me29){
			unchecked {
				#line 29 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\FileSystem.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static   bool exists(string path){
			unchecked {
				#line 33 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\FileSystem.hx"
				return ( global::System.IO.File.Exists(((string) (path) )) || global::System.IO.Directory.Exists(((string) (path) )) );
			}
			#line default
		}
		
		
		public static   void deleteFile(string path){
			unchecked {
				#line 100 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\FileSystem.hx"
				global::System.IO.File.Delete(((string) (path) ));
			}
			#line default
		}
		
		
		public static   void deleteDirectory(string path){
			unchecked {
				#line 105 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\FileSystem.hx"
				global::System.IO.Directory.Delete(((string) (path) ));
			}
			#line default
		}
		
		
		public static   global::Array<object> readDirectory(string path){
			unchecked {
				#line 110 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\FileSystem.hx"
				string[] ret = global::System.IO.Directory.GetFileSystemEntries(((string) (path) ));
				if (( ( ret as global::System.Array ).Length > 0 )) {
					#line 113 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\FileSystem.hx"
					string fst = ret[0];
					string sep = "/";
					if (( global::haxe.lang.StringExt.lastIndexOf(fst, sep, default(global::haxe.lang.Null<int>)) < global::haxe.lang.StringExt.lastIndexOf(fst, "\\", default(global::haxe.lang.Null<int>)) )) {
						#line 116 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\FileSystem.hx"
						sep = "\\";
					}
					
					#line 117 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\FileSystem.hx"
					{
						#line 117 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\FileSystem.hx"
						int _g1 = 0;
						#line 117 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\FileSystem.hx"
						int _g = ( ret as global::System.Array ).Length;
						#line 117 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\FileSystem.hx"
						while (( _g1 < _g )){
							#line 117 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\FileSystem.hx"
							int i = _g1++;
							#line 119 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\FileSystem.hx"
							string path1 = ret[i];
							ret[i] = global::haxe.lang.StringExt.substr(path1, ( global::haxe.lang.StringExt.lastIndexOf(path1, sep, default(global::haxe.lang.Null<int>)) + 1 ), default(global::haxe.lang.Null<int>));
						}
						
					}
					
				}
				
				#line 124 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\FileSystem.hx"
				return global::cs.Lib.array<object>(((object[]) (ret) ));
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				#line 29 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\FileSystem.hx"
				return new global::sys.FileSystem(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr){
			unchecked {
				#line 29 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\FileSystem.hx"
				return new global::sys.FileSystem();
			}
			#line default
		}
		
		
	}
}


