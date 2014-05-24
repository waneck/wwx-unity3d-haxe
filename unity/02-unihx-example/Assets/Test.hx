import unityengine.*;
import unihx.inspector.*;

class Test extends HaxeBehaviour
{
	public var haxeEnum:WrappedValue;
}

enum WrappedValue
{
	/**
		Null
		@label null
	**/
	WNull;

	/**
		Int value
		@label int
	**/
	WInt(value:Int);

	/**
		String Value
		@label string
	**/
	WString(value:String);
}
