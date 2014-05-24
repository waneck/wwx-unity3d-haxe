
#pragma warning disable 109, 114, 219, 429, 168, 162
public  class Test : global::unityengine.HaxeBehaviour {
	public    Test() : base(){
		unchecked {
		}
		#line default
	}
	
	
	public  global::WrappedValue haxeEnum;
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public  class WrappedValue : global::haxe.lang.Enum {
	static WrappedValue() {
		#line 9 "Z:\\var\\dev\\proj\\wwx-pres\\unity\\02-unihx-example\\Assets\\Test.hx"
		global::WrappedValue.constructs = new global::Array<object>(new object[]{"WNull", "WInt", "WString"});
		#line 15 "Z:\\var\\dev\\proj\\wwx-pres\\unity\\02-unihx-example\\Assets\\Test.hx"
		global::WrappedValue.WNull = new global::WrappedValue(((int) (0) ), ((global::Array<object>) (new global::Array<object>(new object[]{})) ));
	}
	public    WrappedValue(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
		unchecked {
		}
		#line default
	}
	
	
	public    WrappedValue(int index, global::Array<object> @params) : base(index, @params){
		unchecked {
		}
		#line default
	}
	
	
	public static  global::Array<object> constructs;
	
	public static  global::WrappedValue WNull;
	
	public static   global::WrappedValue WInt(int @value){
		unchecked {
			#line 21 "Z:\\var\\dev\\proj\\wwx-pres\\unity\\02-unihx-example\\Assets\\Test.hx"
			return new global::WrappedValue(((int) (1) ), ((global::Array<object>) (new global::Array<object>(new object[]{@value})) ));
		}
		#line default
	}
	
	
	public static   global::WrappedValue WString(string @value){
		unchecked {
			#line 27 "Z:\\var\\dev\\proj\\wwx-pres\\unity\\02-unihx-example\\Assets\\Test.hx"
			return new global::WrappedValue(((int) (2) ), ((global::Array<object>) (new global::Array<object>(new object[]{@value})) ));
		}
		#line default
	}
	
	
	public static  new object __hx_createEmpty(){
		unchecked {
			#line 9 "Z:\\var\\dev\\proj\\wwx-pres\\unity\\02-unihx-example\\Assets\\Test.hx"
			return new global::WrappedValue(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
		}
		#line default
	}
	
	
	public static  new object __hx_create(global::Array arr){
		unchecked {
			#line 9 "Z:\\var\\dev\\proj\\wwx-pres\\unity\\02-unihx-example\\Assets\\Test.hx"
			return new global::WrappedValue(((int) (global::haxe.lang.Runtime.toInt(arr[0])) ), ((global::Array<object>) (global::Array<object>.__hx_cast<object>(((global::Array) (arr[1]) ))) ));
		}
		#line default
	}
	
	
}


