
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace sys.io{
	public  class FileOutput : global::cs.io.NativeOutput {
		public    FileOutput(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )){
			unchecked {
			}
			#line default
		}
		
		
		public    FileOutput(global::System.IO.FileStream stream) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )){
			unchecked {
				#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\FileOutput.hx"
				global::sys.io.FileOutput.__hx_ctor_sys_io_FileOutput(this, stream);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_sys_io_FileOutput(global::sys.io.FileOutput __temp_me34, global::System.IO.FileStream stream){
			unchecked {
				#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\FileOutput.hx"
				global::cs.io.NativeOutput.__hx_ctor_cs_io_NativeOutput(__temp_me34, stream);
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				#line 24 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\FileOutput.hx"
				return new global::sys.io.FileOutput(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr){
			unchecked {
				#line 24 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\FileOutput.hx"
				return new global::sys.io.FileOutput(((global::System.IO.FileStream) (arr[0]) ));
			}
			#line default
		}
		
		
	}
}


