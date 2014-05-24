
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace sys.io{
	public  class File : global::haxe.lang.HxObject {
		public    File(global::haxe.lang.EmptyObject empty){
			unchecked {
				#line 25 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\File.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    File(){
			unchecked {
				#line 25 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\File.hx"
				global::sys.io.File.__hx_ctor_sys_io_File(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_sys_io_File(global::sys.io.File __temp_me33){
			unchecked {
				#line 25 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\File.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static   global::sys.io.FileInput read(string path, global::haxe.lang.Null<bool> binary){
			unchecked {
				#line 58 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\File.hx"
				bool __temp_binary31 = ( ( ! (binary.hasValue) ) ? (global::haxe.lang.Runtime.toBool(true)) : (binary.@value) );
				#line 62 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\File.hx"
				global::System.IO.FileStream stream = new global::System.IO.FileStream(((string) (path) ), ((global::System.IO.FileMode) (global::System.IO.FileMode.Open) ), ((global::System.IO.FileAccess) (global::System.IO.FileAccess.Read) ), ((global::System.IO.FileShare) (global::System.IO.FileShare.ReadWrite) ));
				#line 64 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\File.hx"
				return new global::sys.io.FileInput(((global::System.IO.FileStream) (stream) ));
			}
			#line default
		}
		
		
		public static   global::sys.io.FileOutput write(string path, global::haxe.lang.Null<bool> binary){
			unchecked {
				#line 68 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\File.hx"
				bool __temp_binary32 = ( ( ! (binary.hasValue) ) ? (global::haxe.lang.Runtime.toBool(true)) : (binary.@value) );
				#line 72 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\File.hx"
				global::System.IO.FileStream stream = new global::System.IO.FileStream(((string) (path) ), ((global::System.IO.FileMode) (global::System.IO.FileMode.Create) ), ((global::System.IO.FileAccess) (global::System.IO.FileAccess.Write) ), ((global::System.IO.FileShare) (global::System.IO.FileShare.ReadWrite) ));
				#line 74 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\File.hx"
				return new global::sys.io.FileOutput(((global::System.IO.FileStream) (stream) ));
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				#line 25 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\File.hx"
				return new global::sys.io.File(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr){
			unchecked {
				#line 25 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\File.hx"
				return new global::sys.io.File();
			}
			#line default
		}
		
		
	}
}


