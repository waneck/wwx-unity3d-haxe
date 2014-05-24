
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace unihx._internal.editor{
	public  class HaxeCompiler : global::haxe.lang.HxObject {
		public    HaxeCompiler(global::haxe.lang.EmptyObject empty){
			unchecked {
				#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
				{
				}
				
			}
			#line default
		}
		
		
		public    HaxeCompiler(global::unihx._internal.editor.Comp prop){
			unchecked {
				#line 14 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
				global::unihx._internal.editor.HaxeCompiler.__hx_ctor_unihx__internal_editor_HaxeCompiler(this, prop);
			}
			#line default
		}
		
		
		public static   void __hx_ctor_unihx__internal_editor_HaxeCompiler(global::unihx._internal.editor.HaxeCompiler __temp_me39, global::unihx._internal.editor.Comp prop){
			unchecked {
				#line 16 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
				__temp_me39.props = prop;
				switch (global::Type.enumIndex(prop)){
					case 2:
					{
						#line 17 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						int port = ((int) (global::haxe.lang.Runtime.toInt(prop.@params[0])) );
						#line 20 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						__temp_me39.newProcess(port);
						#line 19 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						break;
					}
					
					
					default:
					{
						#line 21 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						{
						}
						
						#line 21 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						break;
					}
					
				}
				
			}
			#line default
		}
		
		
		public static   void reportError(string line){
			unchecked {
				#line 103 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
				global::Array<object> ln = global::haxe.lang.StringExt.split(line, ":");
				ln.reverse();
				string file = global::haxe.lang.Runtime.toString(ln.pop().@value);
				global::haxe.lang.Null<int> lineno = global::Std.parseInt(global::haxe.lang.Runtime.toString(ln.pop().@value));
				string other = global::haxe.lang.Runtime.toString(ln.pop().@value);
				string rest = ln.@join(":");
				#line 110 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
				string fullp = global::System.IO.Path.GetFullPath(((string) (global::System.IO.Path.Combine(((string) ("Assets") ), ((string) (file) ))) ));
				global::System.Type debug = ((global::System.Type) (typeof(global::UnityEngine.Debug)) );
				#line 114 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
				try {
					#line 114 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
					global::UnityEngine.Debug.LogException(((global::System.Exception) (new global::unihx._internal.editor.HaxeError(((string) (line) ), ((string) (fullp) ), lineno.@value)) ));
				}
				catch (global::System.Exception __temp_catchallException58){
					#line 114 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
					global::haxe.lang.Exceptions.exception = __temp_catchallException58;
					#line 118 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
					object __temp_catchall59 = __temp_catchallException58;
					#line 118 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
					if (( __temp_catchall59 is global::haxe.lang.HaxeException )) {
						#line 118 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						__temp_catchall59 = ((global::haxe.lang.HaxeException) (__temp_catchallException58) ).obj;
					}
					
					#line 118 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
					{
						#line 118 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						object e = __temp_catchall59;
						#line 118 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						global::UnityEngine.Debug.LogError(((object) (line) ));
					}
					
				}
				
				
			}
			#line default
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
				return new global::unihx._internal.editor.HaxeCompiler(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
			#line default
		}
		
		
		public static  new object __hx_create(global::Array arr){
			unchecked {
				#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
				return new global::unihx._internal.editor.HaxeCompiler(((global::unihx._internal.editor.Comp) (arr[0]) ));
			}
			#line default
		}
		
		
		public  global::unihx._internal.editor.Comp props;
		
		public  global::sys.io.Process process;
		
		public virtual   void newProcess(int port){
			unchecked {
				#line 27 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
				if (( this.process != default(global::sys.io.Process) )) {
					#line 30 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
					try {
						#line 31 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						this.process.kill();
						this.process.close();
					}
					catch (global::System.Exception __temp_catchallException54){
						#line 30 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						global::haxe.lang.Exceptions.exception = __temp_catchallException54;
						#line 34 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						object __temp_catchall55 = __temp_catchallException54;
						#line 34 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						if (( __temp_catchall55 is global::haxe.lang.HaxeException )) {
							#line 34 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
							__temp_catchall55 = ((global::haxe.lang.HaxeException) (__temp_catchallException54) ).obj;
						}
						
						#line 34 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						{
							#line 34 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
							object e = __temp_catchall55;
							#line 34 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
							{
							}
							
						}
						
					}
					
					
				}
				
				#line 36 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
				this.process = default(global::sys.io.Process);
				this.process = new global::sys.io.Process(((string) ("haxe") ), ((global::Array<object>) (new global::Array<object>(new object[]{"--wait", global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.toString(port), "")})) ));
			}
			#line default
		}
		
		
		public virtual   bool compile(global::Array<object> args, global::haxe.lang.Null<bool> verbose){
			unchecked {
				#line 41 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
				bool __temp_verbose38 = ( ( ! (verbose.hasValue) ) ? (global::haxe.lang.Runtime.toBool(false)) : (verbose.@value) );
				global::sys.io.Process cmd = default(global::sys.io.Process);
				#line 42 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
				{
					#line 42 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
					global::unihx._internal.editor.Comp _g = this.props;
					#line 42 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
					switch (global::Type.enumIndex(_g)){
						case 0:
						{
							#line 45 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
							return true;
						}
						
						
						case 1:
						{
							#line 47 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
							global::haxe.Log.trace.__hx_invoke2_o(default(double), "compile", default(double), new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{302979532, 1547539107, 1648581351, 1830310359}), new global::Array<object>(new object[]{"compile", "unihx._internal.editor.HaxeCompiler", "HaxeCompiler.hx", new global::Array<object>(new object[]{args})}), new global::Array<int>(new int[]{1981972957}), new global::Array<double>(new double[]{((double) (47) )})));
							cmd = new global::sys.io.Process(((string) ("haxe") ), ((global::Array<object>) (args) ));
							#line 46 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
							break;
						}
						
						
						case 2:
						{
							#line 42 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
							int port = ((int) (global::haxe.lang.Runtime.toInt(_g.@params[0])) );
							#line 49 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
							{
								#line 50 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
								if (( ( this.process == default(global::sys.io.Process) ) || ((global::System.Diagnostics.Process) (((object) (this.process.native) )) ).HasExited )) {
									#line 51 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
									this.newProcess(port);
								}
								
								#line 52 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
								args = args.copy();
								args.push("--connect");
								#line 53 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
								args.push(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.toString(port), ""));
								global::haxe.Log.trace.__hx_invoke2_o(default(double), "compile", default(double), new global::haxe.lang.DynamicObject(new global::Array<int>(new int[]{302979532, 1547539107, 1648581351, 1830310359}), new global::Array<object>(new object[]{"compile", "unihx._internal.editor.HaxeCompiler", "HaxeCompiler.hx", new global::Array<object>(new object[]{args})}), new global::Array<int>(new int[]{1981972957}), new global::Array<double>(new double[]{((double) (54) )})));
								cmd = new global::sys.io.Process(((string) ("haxe") ), ((global::Array<object>) (args) ));
							}
							
							#line 49 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
							break;
						}
						
						
					}
					
				}
				
				#line 58 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
				bool ret = true;
				if (( cmd != default(global::sys.io.Process) )) {
					#line 61 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
					global::System.Diagnostics.Stopwatch sw = new global::System.Diagnostics.Stopwatch();
					sw.Start();
					if (( cmd.exitCode() != 0 )) {
						#line 65 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						ret = false;
						global::UnityEngine.Debug.LogError(((object) ("Haxe compilation failed.") ));
					}
					
					#line 68 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
					sw.Stop();
					if (__temp_verbose38) {
						#line 70 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						global::UnityEngine.Debug.Log(((object) (global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Compilation ended (", global::Std.@string(sw.Elapsed)), ")")) ));
					}
					
					#line 71 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
					{
						#line 71 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						int _g1 = 0;
						#line 71 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						string __temp_stmt56 = default(string);
						#line 71 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						{
							#line 71 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
							string s = cmd.stdout.readAll(default(global::haxe.lang.Null<int>)).toString();
							#line 71 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
							__temp_stmt56 = s.Trim();
						}
						
						#line 71 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						global::Array<object> _g11 = global::haxe.lang.StringExt.split(__temp_stmt56, "\n");
						#line 71 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						while (( _g1 < _g11.length )){
							#line 71 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
							string ln = global::haxe.lang.Runtime.toString(_g11[_g1]);
							#line 71 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
							 ++ _g1;
							#line 73 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
							string ln1 = ln.Trim();
							if ( ! (string.Equals(ln1, "")) ) {
								#line 75 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
								global::UnityEngine.Debug.Log(((object) (ln1) ));
							}
							
						}
						
					}
					
					#line 77 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
					{
						#line 77 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						int _g2 = 0;
						#line 77 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						string __temp_stmt57 = default(string);
						#line 77 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						{
							#line 77 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
							string s1 = cmd.stderr.readAll(default(global::haxe.lang.Null<int>)).toString();
							#line 77 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
							__temp_stmt57 = s1.Trim();
						}
						
						#line 77 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						global::Array<object> _g12 = global::haxe.lang.StringExt.split(__temp_stmt57, "\n");
						#line 77 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						while (( _g2 < _g12.length )){
							#line 77 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
							string ln2 = global::haxe.lang.Runtime.toString(_g12[_g2]);
							#line 77 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
							 ++ _g2;
							#line 79 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
							string ln3 = ln2.Trim();
							#line 81 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
							if (string.Equals(ln3, "")) {
								#line 81 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
								continue;
							}
							
							#line 82 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
							if (ln3.StartsWith("Warning")) {
								#line 83 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
								global::UnityEngine.Debug.LogWarning(((object) (ln3) ));
							}
							 else {
								#line 85 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
								global::unihx._internal.editor.HaxeCompiler.reportError(ln3);
							}
							
						}
						
					}
					
				}
				
				#line 88 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
				return ret;
			}
			#line default
		}
		
		
		public virtual   void close(){
			unchecked {
				#line 93 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
				if (( this.process != default(global::sys.io.Process) )) {
					#line 95 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
					this.process.kill();
					this.process.close();
					this.process = default(global::sys.io.Process);
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
				switch (hash){
					case 1900716655:
					{
						#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						this.process = ((global::sys.io.Process) (@value) );
						#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						return @value;
					}
					
					
					case 1217390448:
					{
						#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						this.props = ((global::unihx._internal.editor.Comp) (@value) );
						#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						return @value;
					}
					
					
					default:
					{
						#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
				switch (hash){
					case 1214453688:
					{
						#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("close") ), ((int) (1214453688) ))) );
					}
					
					
					case 57615731:
					{
						#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("compile") ), ((int) (57615731) ))) );
					}
					
					
					case 776783343:
					{
						#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("newProcess") ), ((int) (776783343) ))) );
					}
					
					
					case 1900716655:
					{
						#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						return this.process;
					}
					
					
					case 1217390448:
					{
						#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						return this.props;
					}
					
					
					default:
					{
						#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::Array dynargs){
			unchecked {
				#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
				switch (hash){
					case 1214453688:
					{
						#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						this.close();
						#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						break;
					}
					
					
					case 57615731:
					{
						#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						return this.compile(((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (dynargs[0]) ))) ), global::haxe.lang.Null<object>.ofDynamic<bool>(dynargs[1]));
					}
					
					
					case 776783343:
					{
						#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						this.newProcess(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						break;
					}
					
					
					default:
					{
						#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
				return default(object);
			}
			#line default
		}
		
		
		public override   void __hx_getFields(global::Array<object> baseArr){
			unchecked {
				#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
				baseArr.push("process");
				#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
				baseArr.push("props");
				#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
				{
					#line 9 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
					base.__hx_getFields(baseArr);
				}
				
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace unihx._internal.editor{
	public  class HaxeError : global::System.Exception {
		public    HaxeError(string msg, string file, int line) : base(msg){
			unchecked {
				#line 131 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
				this.msg = msg;
				this.file = file;
				this.line = line;
			}
			#line default
		}
		
		
		public override   string StackTrace{
			get { return _get_StackTrace(); }
		}
		public override   string Message{
			get { return _get_Message(); }
		}
		public  string file;
		
		public  int line;
		
		public  string msg;
		
		private   string _get_Message(){
			unchecked {
				#line 138 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
				return this.msg;
			}
			#line default
		}
		
		
		private   string _get_StackTrace(){
			unchecked {
				#line 143 "Z:\\var\\dev\\proj\\unihx\\unihx\\_internal\\editor\\HaxeCompiler.hx"
				return global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("(at ", this.file), ":"), global::haxe.lang.Runtime.toString(this.line)), ")");
			}
			#line default
		}
		
		
	}
}


