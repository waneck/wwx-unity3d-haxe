
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace sys.io{
	public  class FileInput : global::cs.io.NativeInput {
		public    FileInput(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )){
			unchecked {
			}
			#line default
		}
		
		
		public    FileInput(global::System.IO.FileStream stream) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )){
			unchecked {
				#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\FileInput.hx"
				global::sys.io.FileInput.__hx_ctor_sys_io_FileInput(this, stream);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_sys_io_FileInput(global::sys.io.FileInput __temp_me34, global::System.IO.FileStream stream){
			unchecked {
				#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\FileInput.hx"
				global::cs.io.NativeInput.__hx_ctor_cs_io_NativeInput(__temp_me34, stream);
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				#line 24 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\FileInput.hx"
				return new global::sys.io.FileInput(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr){
			unchecked {
				#line 24 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\FileInput.hx"
				return new global::sys.io.FileInput(((global::System.IO.FileStream) (arr[0]) ));
			}
			#line default
		}
		
		
	}
}


