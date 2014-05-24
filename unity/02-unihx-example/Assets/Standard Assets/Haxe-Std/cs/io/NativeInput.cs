
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace cs.io{
	public  class NativeInput : global::haxe.io.Input {
		public    NativeInput(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )){
			unchecked {
			}
			#line default
		}
		
		
		public    NativeInput(global::System.IO.Stream stream){
			unchecked {
				#line 34 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeInput.hx"
				global::cs.io.NativeInput.__hx_ctor_cs_io_NativeInput(this, stream);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_cs_io_NativeInput(global::cs.io.NativeInput __temp_me21, global::System.IO.Stream stream){
			unchecked {
				#line 36 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeInput.hx"
				__temp_me21.stream = stream;
				if ( ! (stream.CanRead) ) {
					#line 37 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeInput.hx"
					throw global::haxe.lang.HaxeException.wrap("Write-only stream");
				}
				
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				#line 29 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeInput.hx"
				return new global::cs.io.NativeInput(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr){
			unchecked {
				#line 29 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeInput.hx"
				return new global::cs.io.NativeInput(((global::System.IO.Stream) (arr[0]) ));
			}
			#line default
		}
		
		
		public  global::System.IO.Stream stream;
		
		public override   int readByte(){
			unchecked {
				#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeInput.hx"
				int ret = this.stream.ReadByte();
				if (( ret == -1 )) {
					#line 43 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeInput.hx"
					throw global::haxe.lang.HaxeException.wrap(new global::haxe.io.Eof());
				}
				
				#line 44 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeInput.hx"
				return ret;
			}
			#line default
		}
		
		
		public override   int readBytes(global::haxe.io.Bytes s, int pos, int len){
			unchecked {
				#line 49 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeInput.hx"
				if (( ( ( pos < 0 ) || ( len < 0 ) ) || ( ( pos + len ) > s.length ) )) {
					#line 50 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeInput.hx"
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
				}
				
				#line 51 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeInput.hx"
				int ret = this.stream.Read(((byte[]) (s.b) ), ((int) (pos) ), ((int) (len) ));
				if (( ret == 0 )) {
					#line 53 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeInput.hx"
					throw global::haxe.lang.HaxeException.wrap(new global::haxe.io.Eof());
				}
				
				#line 54 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeInput.hx"
				return ret;
			}
			#line default
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				#line 29 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeInput.hx"
				switch (hash){
					case 288167040:
					{
						#line 29 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeInput.hx"
						this.stream = ((global::System.IO.Stream) (@value) );
						#line 29 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeInput.hx"
						return @value;
					}
					
					
					default:
					{
						#line 29 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeInput.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				#line 29 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeInput.hx"
				switch (hash){
					case 243225909:
					{
						#line 29 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeInput.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readBytes") ), ((int) (243225909) ))) );
					}
					
					
					case 1763375486:
					{
						#line 29 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeInput.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readByte") ), ((int) (1763375486) ))) );
					}
					
					
					case 288167040:
					{
						#line 29 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeInput.hx"
						return this.stream;
					}
					
					
					default:
					{
						#line 29 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeInput.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr){
			unchecked {
				#line 29 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeInput.hx"
				baseArr.push("stream");
				#line 29 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeInput.hx"
				{
					#line 29 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeInput.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
	}
}


