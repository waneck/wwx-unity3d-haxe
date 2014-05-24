
#pragma warning disable 109, 114, 219, 429, 168, 162
public  class EReg : global::haxe.lang.HxObject {
	public    EReg(global::haxe.lang.EmptyObject empty){
		unchecked {
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public    EReg(string r, string opt){
		unchecked {
			#line 34 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
			global::EReg.__hx_ctor__EReg(this, r, opt);
		}
		#line default
	}
	
	
	public static   void __hx_ctor__EReg(global::EReg __temp_me6, string r, string opt){
		unchecked {
			#line 35 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
			int opts = ((int) (global::haxe.lang.Runtime.toInt(((object) (global::System.Text.RegularExpressions.RegexOptions.CultureInvariant) ))) );
			{
				#line 36 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
				int _g1 = 0;
				#line 36 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
				int _g = opt.Length;
				#line 36 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
				while (( _g1 < _g )){
					#line 36 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
					int i = _g1++;
					{
						#line 37 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
						int _g2 = default(int);
						#line 37 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
						_g2 = ((int) (opt[i]) );
						#line 37 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
						switch (_g2){
							case 105:
							{
								#line 40 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
								opts |= ((int) (global::haxe.lang.Runtime.toInt(((object) (global::System.Text.RegularExpressions.RegexOptions.IgnoreCase) ))) );
								#line 40 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
								break;
							}
							
							
							case 103:
							{
								#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
								__temp_me6.isGlobal = true;
								#line 42 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
								break;
							}
							
							
							case 109:
							{
								#line 44 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
								opts |= ((int) (global::haxe.lang.Runtime.toInt(((object) (global::System.Text.RegularExpressions.RegexOptions.Multiline) ))) );
								#line 44 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
								break;
							}
							
							
						}
						
					}
					
				}
				
			}
			
			#line 52 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
			__temp_me6.regex = new global::System.Text.RegularExpressions.Regex(((string) (r) ), ((global::System.Text.RegularExpressions.RegexOptions) (((object) (opts) )) ));
		}
		#line default
	}
	
	
	public static  new object __hx_createEmpty(){
		unchecked {
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
			return new global::EReg(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
		}
		#line default
	}
	
	
	public static  new object __hx_create(global::Array arr){
		unchecked {
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
			return new global::EReg(global::haxe.lang.Runtime.toString(arr[0]), global::haxe.lang.Runtime.toString(arr[1]));
		}
		#line default
	}
	
	
	public  global::System.Text.RegularExpressions.Regex regex;
	
	public  bool isGlobal;
	
	public virtual   global::Array<object> split(string s){
		unchecked {
			#line 87 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
			if (this.isGlobal) {
				#line 88 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
				return global::cs.Lib.array<object>(((object[]) (this.regex.Split(((string) (s) ))) ));
			}
			
			#line 89 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
			global::System.Text.RegularExpressions.Match m = this.regex.Match(((string) (s) ));
			if ( ! (( m as global::System.Text.RegularExpressions.Group ).Success) ) {
				#line 90 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
				return new global::Array<object>(new object[]{s});
			}
			
			#line 91 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
			return new global::Array<object>(new object[]{s.Substring(((int) (0) ), ((int) (( m as global::System.Text.RegularExpressions.Capture ).Index) )), s.Substring(((int) (( ( m as global::System.Text.RegularExpressions.Capture ).Index + ( m as global::System.Text.RegularExpressions.Capture ).Length )) ))});
		}
		#line default
	}
	
	
	public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
		unchecked {
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
			switch (hash){
				case 1821933:
				{
					#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
					this.isGlobal = global::haxe.lang.Runtime.toBool(@value);
					#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
					return @value;
				}
				
				
				case 1723805383:
				{
					#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
					this.regex = ((global::System.Text.RegularExpressions.Regex) (@value) );
					#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
					return @value;
				}
				
				
				default:
				{
					#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
					return base.__hx_setField(field, hash, @value, handleProperties);
				}
				
			}
			
		}
		#line default
	}
	
	
	public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
		unchecked {
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
			switch (hash){
				case 24046298:
				{
					#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("split") ), ((int) (24046298) ))) );
				}
				
				
				case 1821933:
				{
					#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
					return this.isGlobal;
				}
				
				
				case 1723805383:
				{
					#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
					return this.regex;
				}
				
				
				default:
				{
					#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
					return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
				}
				
			}
			
		}
		#line default
	}
	
	
	public override   object __hx_invokeField(string field, int hash, global::Array dynargs){
		unchecked {
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
			switch (hash){
				case 24046298:
				{
					#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
					return this.split(global::haxe.lang.Runtime.toString(dynargs[0]));
				}
				
				
				default:
				{
					#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
					return base.__hx_invokeField(field, hash, dynargs);
				}
				
			}
			
		}
		#line default
	}
	
	
	public override   void __hx_getFields(global::Array<object> baseArr){
		unchecked {
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
			baseArr.push("isGlobal");
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
			baseArr.push("regex");
			#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
			{
				#line 27 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\EReg.hx"
				base.__hx_getFields(baseArr);
			}
			
		}
		#line default
	}
	
	
}


