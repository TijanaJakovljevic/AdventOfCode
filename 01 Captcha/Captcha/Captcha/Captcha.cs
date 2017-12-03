using System.Collections.Generic;
using System.Linq;

namespace Captcha
{
	public class Captcha
	{
		private readonly List<int> _captchaList;
		private int _sum;
		public int CaptchaLength => _captchaList.Count;

		public Captcha(string captcha)
		{
			_captchaList = captcha.Select(num => int.Parse(num.ToString())).ToList();
			_captchaList.Reverse();
		}

		public int CalculateCaptchaWithEqualityStep(int step)
		{
			for (var i = 0; i < CaptchaLength; i++)
			{
				if (_captchaList[i] == _captchaList[(i + step) % CaptchaLength])
				{
					_sum += _captchaList[i];
				}
			}
			return _sum;
		}
	}
}