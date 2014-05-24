
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace unihx.inspector{
	public  struct Slider<T> {
		public    Slider(T min, T max, global::haxe.lang.Null<T> @value){
			unchecked {
				#line 14 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Slider.hx"
				this.minLimit = min;
				this.maxLimit = max;
				if ( ! (@value.hasValue) ) {
					#line 16 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Slider.hx"
					this.@value = this.minLimit;
				}
				 else {
					#line 16 "Z:\\var\\dev\\proj\\unihx\\unihx\\inspector\\Slider.hx"
					this.@value = @value.@value;
				}
				
			}
			#line default
		}
		
		
		public  T minLimit;
		
		public  T maxLimit;
		
		public  T @value;
		
	}
}


