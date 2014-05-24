
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace cs.io{
	public  class NativeOutput : global::haxe.io.Output {
		public    NativeOutput(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )){
			unchecked {
			}
			#line default
		}
		
		
		public    NativeOutput(global::System.IO.Stream stream){
			unchecked {
				#line 31 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeOutput.hx"
				global::cs.io.NativeOutput.__hx_ctor_cs_io_NativeOutput(this, stream);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_cs_io_NativeOutput(global::cs.io.NativeOutput __temp_me23, global::System.IO.Stream stream){
			unchecked {
				#line 33 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeOutput.hx"
				__temp_me23.stream = stream;
				if ( ! (stream.CanWrite) ) {
					#line 34 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeOutput.hx"
					throw global::haxe.lang.HaxeException.wrap("Read-only stream");
				}
				
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeOutput.hx"
				return new global::cs.io.NativeOutput(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr){
			unchecked {
				#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeOutput.hx"
				return new global::cs.io.NativeOutput(((global::System.IO.Stream) (arr[0]) ));
			}
			#line default
		}
		
		
		public  global::System.IO.Stream stream;
		
		public override   void writeByte(int c){
			unchecked {
				#line 39 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeOutput.hx"
				this.stream.WriteByte(((byte) (c) ));
			}
			#line default
		}
		
		
		public virtual   void close(){
			unchecked {
				#line 44 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeOutput.hx"
				this.stream.Close();
			}
			#line default
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeOutput.hx"
				switch (hash){
					case 288167040:
					{
						#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeOutput.hx"
						this.stream = ((global::System.IO.Stream) (@value) );
						#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeOutput.hx"
						return @value;
					}
					
					
					default:
					{
						#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeOutput.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeOutput.hx"
				switch (hash){
					case 1214453688:
					{
						#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeOutput.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("close") ), ((int) (1214453688) ))) );
					}
					
					
					case 1238832007:
					{
						#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeOutput.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("writeByte") ), ((int) (1238832007) ))) );
					}
					
					
					case 288167040:
					{
						#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeOutput.hx"
						return this.stream;
					}
					
					
					default:
					{
						#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeOutput.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::Array dynargs){
			unchecked {
				#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeOutput.hx"
				switch (hash){
					case 1238832007:
					{
						#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeOutput.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 1214453688:
					{
						#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeOutput.hx"
						this.close();
						#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeOutput.hx"
						break;
					}
					
					
					default:
					{
						#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeOutput.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeOutput.hx"
				return default(object);
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr){
			unchecked {
				#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeOutput.hx"
				baseArr.push("stream");
				#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeOutput.hx"
				{
					#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\io\\NativeOutput.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
	}
}


