
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.io{
	public  class Path : global::haxe.lang.HxObject {
		public    Path(global::haxe.lang.EmptyObject empty){
			unchecked {
				#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    Path(string path){
			unchecked {
				#line 76 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
				global::haxe.io.Path.__hx_ctor_haxe_io_Path(this, path);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_haxe_io_Path(global::haxe.io.Path __temp_me28, string path){
			unchecked {
				#line 77 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
				switch (path){
					case ".":case "..":
					{
						#line 79 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
						__temp_me28.dir = path;
						__temp_me28.file = "";
						return ;
					}
					
					
				}
				
				#line 83 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
				int c1 = global::haxe.lang.StringExt.lastIndexOf(path, "/", default(global::haxe.lang.Null<int>));
				int c2 = global::haxe.lang.StringExt.lastIndexOf(path, "\\", default(global::haxe.lang.Null<int>));
				if (( c1 < c2 )) {
					#line 86 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
					__temp_me28.dir = global::haxe.lang.StringExt.substr(path, 0, new global::haxe.lang.Null<int>(c2, true));
					path = global::haxe.lang.StringExt.substr(path, ( c2 + 1 ), default(global::haxe.lang.Null<int>));
					__temp_me28.backslash = true;
				}
				 else {
					#line 89 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
					if (( c2 < c1 )) {
						#line 90 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
						__temp_me28.dir = global::haxe.lang.StringExt.substr(path, 0, new global::haxe.lang.Null<int>(c1, true));
						path = global::haxe.lang.StringExt.substr(path, ( c1 + 1 ), default(global::haxe.lang.Null<int>));
					}
					 else {
						#line 93 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
						__temp_me28.dir = default(string);
					}
					
				}
				
				#line 94 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
				int cp = global::haxe.lang.StringExt.lastIndexOf(path, ".", default(global::haxe.lang.Null<int>));
				if (( cp != -1 )) {
					#line 96 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
					__temp_me28.ext = global::haxe.lang.StringExt.substr(path, ( cp + 1 ), default(global::haxe.lang.Null<int>));
					__temp_me28.file = global::haxe.lang.StringExt.substr(path, 0, new global::haxe.lang.Null<int>(cp, true));
				}
				 else {
					#line 99 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
					__temp_me28.ext = default(string);
					__temp_me28.file = path;
				}
				
			}
			#line default
		}
		
		
		public static   string withoutDirectory(string path){
			unchecked {
				#line 135 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
				global::haxe.io.Path s = new global::haxe.io.Path(((string) (path) ));
				s.dir = default(string);
				return s.toString();
			}
			#line default
		}
		
		
		public static   string directory(string path){
			unchecked {
				#line 148 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
				global::haxe.io.Path s = new global::haxe.io.Path(((string) (path) ));
				if (string.Equals(s.dir, default(string))) {
					#line 150 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
					return "";
				}
				
				#line 151 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
				return s.dir;
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
				return new global::haxe.io.Path(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr){
			unchecked {
				#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
				return new global::haxe.io.Path(global::haxe.lang.Runtime.toString(arr[0]));
			}
			#line default
		}
		
		
		public  string dir;
		
		public  string file;
		
		public  string ext;
		
		public  bool backslash;
		
		public virtual   string toString(){
			unchecked {
				#line 115 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
				return global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat((( (string.Equals(this.dir, default(string))) ? ("") : (global::haxe.lang.Runtime.concat(this.dir, (( (this.backslash) ? ("\\") : ("/") )))) )), this.file), (( (string.Equals(this.ext, default(string))) ? ("") : (global::haxe.lang.Runtime.concat(".", this.ext)) )));
			}
			#line default
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
				switch (hash){
					case 1212528822:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
						this.backslash = global::haxe.lang.Runtime.toBool(@value);
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
						return @value;
					}
					
					
					case 5049505:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
						this.ext = global::haxe.lang.Runtime.toString(@value);
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
						return @value;
					}
					
					
					case 1136381564:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
						this.file = global::haxe.lang.Runtime.toString(@value);
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
						return @value;
					}
					
					
					case 4996429:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
						this.dir = global::haxe.lang.Runtime.toString(@value);
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
						return @value;
					}
					
					
					default:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
				switch (hash){
					case 946786476:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("toString") ), ((int) (946786476) ))) );
					}
					
					
					case 1212528822:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
						return this.backslash;
					}
					
					
					case 5049505:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
						return this.ext;
					}
					
					
					case 1136381564:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
						return this.file;
					}
					
					
					case 4996429:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
						return this.dir;
					}
					
					
					default:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::Array dynargs){
			unchecked {
				#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
				switch (hash){
					case 946786476:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
						return this.toString();
					}
					
					
					default:
					{
						#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr){
			unchecked {
				#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
				baseArr.push("backslash");
				#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
				baseArr.push("ext");
				#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
				baseArr.push("file");
				#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
				baseArr.push("dir");
				#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
				{
					#line 31 "C:\\HaxeToolkit\\haxe\\std\\haxe\\io\\Path.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
		public override string ToString(){
			return this.toString();
		}
		
		
	}
}


