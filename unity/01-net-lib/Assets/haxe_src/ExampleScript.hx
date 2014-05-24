import cs.NativeArray;
import unityengine.*;

@:nativeGen class ExampleScript extends MonoBehaviour
{
	public var stringProp:String;
	public var arrayProp:NativeArray<Int>;
	public var vectorProp:Vector3;

	function Update()
	{
		Debug.Log("I'm working!");
	}
}
