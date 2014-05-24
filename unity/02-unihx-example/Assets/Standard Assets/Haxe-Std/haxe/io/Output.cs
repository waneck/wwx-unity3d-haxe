
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io{
	public  class Output : global::haxe.lang.HxObject {
		public    Output(global::haxe.lang.EmptyObject empty){
			unchecked {
				#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    Output(){
			unchecked {
				#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				global::haxe.io.Output.__hx_ctor_haxe_io_Output(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_haxe_io_Output(global::haxe.io.Output __temp_me22){
			unchecked {
				#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				return new global::haxe.io.Output(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr){
			unchecked {
				#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				return new global::haxe.io.Output();
			}
			#line default
		}
		
		
		public virtual   void writeByte(int c){
			unchecked {
				#line 39 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				throw global::haxe.lang.HaxeException.wrap("Not implemented");
			}
			#line default
		}
		
		
		public virtual   int writeBytes(global::haxe.io.Bytes s, int pos, int len){
			unchecked {
				#line 43 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				int k = len;
				byte[] b = s.b;
				#line 46 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				if (( ( ( pos < 0 ) || ( len < 0 ) ) || ( ( pos + len ) > s.length ) )) {
					#line 47 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
				}
				
				#line 49 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				while (( k > 0 )){
					#line 57 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					this.writeByte(((int) (b[pos]) ));
					#line 59 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					pos++;
					k--;
				}
				
				#line 62 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				return len;
			}
			#line default
		}
		
		
		public virtual   void writeFullBytes(global::haxe.io.Bytes s, int pos, int len){
			unchecked {
				#line 90 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				while (( len > 0 )){
					#line 91 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
					int k = this.writeBytes(s, pos, len);
					pos += k;
					len -= k;
				}
				
			}
			#line default
		}
		
		
		public virtual   void writeString(string s){
			unchecked {
				#line 317 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				global::haxe.io.Bytes b = global::haxe.io.Bytes.ofString(s);
				#line 319 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				this.writeFullBytes(b, 0, b.length);
			}
			#line default
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				switch (hash){
					case 640252688:
					{
						#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("writeString") ), ((int) (640252688) ))) );
					}
					
					
					case 610723709:
					{
						#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("writeFullBytes") ), ((int) (610723709) ))) );
					}
					
					
					case 1381630732:
					{
						#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("writeBytes") ), ((int) (1381630732) ))) );
					}
					
					
					case 1238832007:
					{
						#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("writeByte") ), ((int) (1238832007) ))) );
					}
					
					
					default:
					{
						#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::Array dynargs){
			unchecked {
				#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				switch (hash){
					case 640252688:
					{
						#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						this.writeString(global::haxe.lang.Runtime.toString(dynargs[0]));
						#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						break;
					}
					
					
					case 610723709:
					{
						#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						this.writeFullBytes(((global::haxe.io.Bytes) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ));
						#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						break;
					}
					
					
					case 1381630732:
					{
						#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return this.writeBytes(((global::haxe.io.Bytes) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ));
					}
					
					
					case 1238832007:
					{
						#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						this.writeByte(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						break;
					}
					
					
					default:
					{
						#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 30 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Output.hx"
				return default(object);
			}
			#line default
		}
		
		
	}
}


