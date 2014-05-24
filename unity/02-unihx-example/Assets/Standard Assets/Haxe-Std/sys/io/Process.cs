
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace sys.io{
	public  class Process : global::haxe.lang.HxObject {
		public    Process(global::haxe.lang.EmptyObject empty){
			unchecked {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    Process(string cmd, global::Array<object> args){
			unchecked {
				#line 37 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				global::sys.io.Process.__hx_ctor_sys_io_Process(this, cmd, args);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_sys_io_Process(global::sys.io.Process __temp_me36, string cmd, global::Array<object> args){
			unchecked {
				#line 39 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				__temp_me36.native = new global::System.Diagnostics.Process();
				__temp_me36.native.StartInfo.FileName = cmd;
				global::StringBuf buf = new global::StringBuf();
				{
					#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
					int _g = 0;
					#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
					while (( _g < args.length )){
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						string arg = global::haxe.lang.Runtime.toString(args[_g]);
						#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						 ++ _g;
						#line 44 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						buf.b.Append(((object) ("\"") ));
						{
							#line 45 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
							string x = global::StringTools.replace(arg, "\"", "\\\"");
							#line 45 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
							buf.b.Append(((object) (global::Std.@string(x)) ));
						}
						
						#line 46 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						buf.b.Append(((object) ("\" ") ));
					}
					
				}
				
				#line 48 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				__temp_me36.native.StartInfo.Arguments = buf.toString();
				__temp_me36.native.StartInfo.RedirectStandardError = __temp_me36.native.StartInfo.RedirectStandardInput = __temp_me36.native.StartInfo.RedirectStandardOutput = true;
				__temp_me36.native.StartInfo.UseShellExecute = false;
				#line 52 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				__temp_me36.native.Start();
				#line 54 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				__temp_me36.stdout = new global::cs.io.NativeInput(((global::System.IO.Stream) (__temp_me36.native.StandardOutput.BaseStream) ));
				__temp_me36.stderr = new global::cs.io.NativeInput(((global::System.IO.Stream) (__temp_me36.native.StandardError.BaseStream) ));
				__temp_me36.stdin = new global::cs.io.NativeOutput(((global::System.IO.Stream) (__temp_me36.native.StandardInput.BaseStream) ));
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				return new global::sys.io.Process(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr){
			unchecked {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				return new global::sys.io.Process(global::haxe.lang.Runtime.toString(arr[0]), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (arr[1]) ))) ));
			}
			#line default
		}
		
		
		public  global::haxe.io.Input stdout;
		
		public  global::haxe.io.Input stderr;
		
		public  global::haxe.io.Output stdin;
		
		public  global::System.Diagnostics.Process native;
		
		public virtual   int exitCode(){
			unchecked {
				#line 66 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				this.native.WaitForExit();
				return this.native.ExitCode;
			}
			#line default
		}
		
		
		public virtual   void close(){
			unchecked {
				#line 72 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				this.native.Close();
			}
			#line default
		}
		
		
		public virtual   void kill(){
			unchecked {
				#line 77 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				this.native.Kill();
			}
			#line default
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				switch (hash){
					case 572311959:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						this.native = ((global::System.Diagnostics.Process) (@value) );
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return @value;
					}
					
					
					case 68006728:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						this.stdin = ((global::haxe.io.Output) (@value) );
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return @value;
					}
					
					
					case 132916898:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						this.stderr = ((global::haxe.io.Input) (@value) );
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return @value;
					}
					
					
					case 133414859:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						this.stdout = ((global::haxe.io.Input) (@value) );
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return @value;
					}
					
					
					default:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				switch (hash){
					case 1191829406:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("kill") ), ((int) (1191829406) ))) );
					}
					
					
					case 1214453688:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("close") ), ((int) (1214453688) ))) );
					}
					
					
					case 25738091:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("exitCode") ), ((int) (25738091) ))) );
					}
					
					
					case 572311959:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return this.native;
					}
					
					
					case 68006728:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return this.stdin;
					}
					
					
					case 132916898:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return this.stderr;
					}
					
					
					case 133414859:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return this.stdout;
					}
					
					
					default:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::Array dynargs){
			unchecked {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				switch (hash){
					case 1191829406:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						this.kill();
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						break;
					}
					
					
					case 1214453688:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						this.close();
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						break;
					}
					
					
					case 25738091:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return this.exitCode();
					}
					
					
					default:
					{
						#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				return default(object);
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr){
			unchecked {
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				baseArr.push("native");
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				baseArr.push("stdin");
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				baseArr.push("stderr");
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				baseArr.push("stdout");
				#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
				{
					#line 28 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\sys\\io\\Process.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
	}
}


