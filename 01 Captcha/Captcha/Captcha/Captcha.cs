using System.Collections.Generic;
using System.Linq;

namespace Captcha
{
	public class Captcha
	{
		private readonly List<int> _captchaList;
		private int _sum;

		public Captcha(string captcha)
		{
			_captchaList = captcha.Select(num => int.Parse(num.ToString())).ToList();
			_captchaList.Reverse();
		}

		public int Calculate1()
		{
			var count = _captchaList.Count;
			for (var i = 0; i < count; i++)
			{
				if (_captchaList[i] == _captchaList[(i + 1) % count])
				{
					_sum += _captchaList[i];
				}
			}
			return _sum;
		}


		public int Calculate2()
		{
			var count = _captchaList.Count;
			var step = count / 2;

			for (var i = 0; i < count; i++)
			{
				var a = _captchaList[i];
				var b = (i + step) % count;
				var c = _captchaList[(i + step) % count];
				if (_captchaList[i] == _captchaList[(i + step) % count])
				{
					_sum += _captchaList[i];
				}
			}
			return _sum;
		}
	}
}