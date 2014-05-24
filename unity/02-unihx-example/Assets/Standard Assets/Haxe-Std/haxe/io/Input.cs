
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io{
	public  class Input : global::haxe.lang.HxObject {
		public    Input(global::haxe.lang.EmptyObject empty){
			unchecked {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    Input(){
			unchecked {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				global::haxe.io.Input.__hx_ctor_haxe_io_Input(this);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_haxe_io_Input(global::haxe.io.Input __temp_me21){
			unchecked {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				return new global::haxe.io.Input(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr){
			unchecked {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				return new global::haxe.io.Input();
			}
			#line default
		}
		
		
		public virtual   int readByte(){
			unchecked {
				#line 42 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				throw global::haxe.lang.HaxeException.wrap("Not implemented");
			}
			#line default
		}
		
		
		public virtual   int readBytes(global::haxe.io.Bytes s, int pos, int len){
			unchecked {
				#line 47 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				int k = len;
				byte[] b = s.b;
				if (( ( ( pos < 0 ) || ( len < 0 ) ) || ( ( pos + len ) > s.length ) )) {
					#line 50 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
				}
				
				#line 51 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				while (( k > 0 )){
					#line 59 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					b[pos] = ((byte) (this.readByte()) );
					#line 61 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					pos++;
					k--;
				}
				
				#line 64 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				return len;
			}
			#line default
		}
		
		
		public virtual   global::haxe.io.Bytes readAll(global::haxe.lang.Null<int> bufsize){
			unchecked {
				#line 78 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				if ( ! (bufsize.hasValue) ) {
					#line 82 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					bufsize = new global::haxe.lang.Null<int>(16384, true);
				}
				
				#line 85 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				global::haxe.io.Bytes buf = global::haxe.io.Bytes.alloc(bufsize.@value);
				global::haxe.io.BytesBuffer total = new global::haxe.io.BytesBuffer();
				#line 88 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				try {
					#line 88 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					while (true){
						#line 89 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						int len = this.readBytes(buf, 0, bufsize.@value);
						if (( len == 0 )) {
							#line 91 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
							throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.Blocked);
						}
						
						#line 92 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						{
							#line 92 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
							if (( ( len < 0 ) || ( len > buf.length ) )) {
								#line 92 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
								throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.OutsideBounds);
							}
							
							#line 92 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
							( total.b as global::System.IO.Stream ).Write(((byte[]) (buf.b) ), ((int) (0) ), ((int) (len) ));
						}
						
					}
					
				}
				catch (global::System.Exception __temp_catchallException50){
					#line 88 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					global::haxe.lang.Exceptions.exception = __temp_catchallException50;
					#line 94 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					object __temp_catchall51 = __temp_catchallException50;
					#line 94 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					if (( __temp_catchall51 is global::haxe.lang.HaxeException )) {
						#line 94 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						__temp_catchall51 = ((global::haxe.lang.HaxeException) (__temp_catchallException50) ).obj;
					}
					
					#line 94 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					if (( __temp_catchall51 is global::haxe.io.Eof )) {
						#line 94 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						global::haxe.io.Eof e = ((global::haxe.io.Eof) (__temp_catchall51) );
						#line 94 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						{
							#line 94 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
							{
							}
							
						}
						
					}
					 else {
						#line 94 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						throw;
					}
					
				}
				
				
				#line 96 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				return total.getBytes();
			}
			#line default
		}
		
		
		public virtual   string readLine(){
			unchecked {
				#line 128 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				global::StringBuf buf = new global::StringBuf();
				int last = default(int);
				string s = default(string);
				try {
					#line 132 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					while (( (last = this.readByte()) != 10 )){
						#line 133 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						buf.b.Append(((char) (last) ));
					}
					
					#line 134 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					s = buf.toString();
					if (global::haxe.lang.Runtime.eq((global::haxe.lang.StringExt.charCodeAt(s, ( s.Length - 1 ))).toDynamic(), 13)) {
						#line 135 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						s = global::haxe.lang.StringExt.substr(s, 0, new global::haxe.lang.Null<int>(-1, true));
					}
					
				}
				catch (global::System.Exception __temp_catchallException52){
					#line 131 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					global::haxe.lang.Exceptions.exception = __temp_catchallException52;
					#line 136 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					object __temp_catchall53 = __temp_catchallException52;
					#line 136 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					if (( __temp_catchall53 is global::haxe.lang.HaxeException )) {
						#line 136 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						__temp_catchall53 = ((global::haxe.lang.HaxeException) (__temp_catchallException52) ).obj;
					}
					
					#line 136 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
					if (( __temp_catchall53 is global::haxe.io.Eof )) {
						#line 136 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						global::haxe.io.Eof e = ((global::haxe.io.Eof) (__temp_catchall53) );
						#line 136 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						{
							#line 137 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
							s = buf.toString();
							if (( s.Length == 0 )) {
								#line 139 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
								throw global::haxe.lang.HaxeException.wrap(e);
							}
							
						}
						
					}
					 else {
						#line 136 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						throw;
					}
					
				}
				
				
				#line 141 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				return s;
			}
			#line default
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				switch (hash){
					case 1873474154:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readLine") ), ((int) (1873474154) ))) );
					}
					
					
					case 46374763:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readAll") ), ((int) (46374763) ))) );
					}
					
					
					case 243225909:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readBytes") ), ((int) (243225909) ))) );
					}
					
					
					case 1763375486:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readByte") ), ((int) (1763375486) ))) );
					}
					
					
					default:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::Array dynargs){
			unchecked {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
				switch (hash){
					case 1873474154:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return this.readLine();
					}
					
					
					case 46374763:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return this.readAll(global::haxe.lang.Null<object>.ofDynamic<int>(dynargs[0]));
					}
					
					
					case 243225909:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return this.readBytes(((global::haxe.io.Bytes) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ));
					}
					
					
					case 1763375486:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return this.readByte();
					}
					
					
					default:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Input.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
			#line default
		}
		
		
	}
}


