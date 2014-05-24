
#pragma warning disable 109, 114, 219, 429, 168, 162
public  class Std {
	public    Std(){
		unchecked {
			#line 26 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			{
			}
			
		}
		#line default
	}
	
	
	public static   bool @is(object v, object t){
		unchecked {
			#line 29 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			if (global::haxe.lang.Runtime.eq(v, default(object))) {
				#line 30 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				return global::haxe.lang.Runtime.eq(t, typeof(object));
			}
			
			#line 31 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			if (global::haxe.lang.Runtime.eq(t, default(object))) {
				#line 32 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				return false;
			}
			
			#line 33 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			global::System.Type clt = ((global::System.Type) (t) );
			if (global::haxe.lang.Runtime.typeEq(clt, default(global::System.Type))) {
				#line 35 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				return false;
			}
			
			#line 36 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			string name = global::haxe.lang.Runtime.toString(clt);
			#line 38 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			switch (name){
				case "System.Double":
				{
					#line 41 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					return v is double || v is int;
				}
				
				
				case "System.Int32":
				{
					#line 43 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					return haxe.lang.Runtime.isInt(v);
				}
				
				
				case "System.Boolean":
				{
					#line 45 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					return v is bool;
				}
				
				
				case "System.Object":
				{
					#line 47 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					return true;
				}
				
				
			}
			
			#line 50 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			return clt.IsAssignableFrom(((global::System.Type) (global::cs.Lib.nativeType(v)) ));
		}
		#line default
	}
	
	
	public static   string @string(object s){
		unchecked {
			#line 54 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			if (global::haxe.lang.Runtime.eq(s, default(object))) {
				#line 55 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				return "null";
			}
			
			#line 56 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			if (( s is bool )) {
				#line 57 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				if (global::haxe.lang.Runtime.toBool(s)) {
					#line 57 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					return "true";
				}
				 else {
					#line 57 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					return "false";
				}
				
			}
			
			#line 59 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			return s.ToString();
		}
		#line default
	}
	
	
	public static   global::haxe.lang.Null<int> parseInt(string x){
		unchecked {
			#line 67 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			if (string.Equals(x, default(string))) {
				#line 67 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				return default(global::haxe.lang.Null<int>);
			}
			
			#line 69 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			int ret = 0;
			int @base = 10;
			int i = -1;
			int len = x.Length;
			#line 74 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			if (( x.StartsWith("0") && ( len > 2 ) )) {
				#line 76 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				int c = ((int) (global::haxe.lang.Runtime.toInt(x[1])) );
				if (( ( c == 120 ) || ( c == 88 ) )) {
					#line 79 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					i = 1;
					@base = 16;
				}
				
			}
			
			#line 84 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			bool foundAny = false;
			bool isNeg = false;
			while ((  ++ i < len )){
				#line 88 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				int c1 = default(int);
				#line 88 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				c1 = ((int) (global::haxe.lang.Runtime.toInt(x[i])) );
				if ( ! (foundAny) ) {
					#line 91 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					switch (c1){
						case 45:
						{
							#line 94 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
							isNeg = true;
							continue;
						}
						
						
						case 32:case 9:case 10:case 13:case 43:
						{
							#line 97 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
							if (isNeg) {
								#line 98 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
								return default(global::haxe.lang.Null<int>);
							}
							
							#line 99 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
							continue;
						}
						
						
					}
					
				}
				
				#line 103 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				if (( ( c1 >= 48 ) && ( c1 <= 57 ) )) {
					#line 105 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					if ((  ! (foundAny)  && ( c1 == 48 ) )) {
						#line 107 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
						foundAny = true;
						continue;
					}
					
					#line 110 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					ret *= @base;
					#line 110 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					foundAny = true;
					#line 112 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					ret += ( c1 - 48 );
				}
				 else {
					#line 113 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					if (( @base == 16 )) {
						#line 114 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
						if (( ( c1 >= 97 ) && ( c1 <= 102 ) )) {
							#line 115 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
							ret *= @base;
							#line 115 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
							foundAny = true;
							ret += ( ( c1 - 97 ) + 10 );
						}
						 else {
							#line 117 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
							if (( ( c1 >= 65 ) && ( c1 <= 70 ) )) {
								#line 118 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
								ret *= @base;
								#line 118 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
								foundAny = true;
								ret += ( ( c1 - 65 ) + 10 );
							}
							 else {
								#line 121 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
								break;
							}
							
						}
						
					}
					 else {
						#line 124 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
						break;
					}
					
				}
				
			}
			
			#line 128 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
			if (foundAny) {
				#line 129 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				if (isNeg) {
					#line 129 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					return new global::haxe.lang.Null<int>( - (ret) , true);
				}
				 else {
					#line 129 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
					return new global::haxe.lang.Null<int>(ret, true);
				}
				
			}
			 else {
				#line 131 "C:\\HaxeToolkit\\haxe\\std\\cs\\_std\\Std.hx"
				return default(global::haxe.lang.Null<int>);
			}
			
		}
		#line default
	}
	
	
}


