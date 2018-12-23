using System.Security.Cryptography;

namespace ZHANHUO.Common
{
	public class rsautil
	{
		private static rsautil rsautil_0;

		private byte[] byte_0;

		private byte[] byte_1;

		private RSACryptoServiceProvider rsacryptoServiceProvider_0;

		private rsautil()
		{
			rsacryptoServiceProvider_0 = new RSACryptoServiceProvider(512);
			RSAParameters parameters = new RSAParameters
			{
				Modulus = (byte_0 = bytetool.toArray("66f0d7a85d710aed4f75dd06491b6bb82fb228aefc17a570da6c2de4b2459f73c701b131463b230d8837b98f8d514a0c7e8ebce0c507606fc28c4814496cda43")),
				Exponent = (byte_1 = bytetool.toArray("10001")),
				D = bytetool.toArray("99005f895f59256493361bcdbbdb85bfbd249053855da0089c9d2d993d5f3e1e670dd722befeeebbc6ebd9f122351565b2552c95c34351e003f7a9c5fccf901"),
				P = bytetool.toArray("cda139b9e9049e7b9ce8245116e824029a5ccd1df1ca2f9c3cc6293e38077a93"),
				Q = bytetool.toArray("80281fdfed1a79fcc0d2050548e57862d9468b3ba29039d0f130f9ab9488ff91"),
				DP = bytetool.toArray("b94f838b5440926689f7f6ca911f315c9b29e8bc04ab960e72028f26802dd53b"),
				DQ = bytetool.toArray("15742219df5c4e4d848de3ef458bbc8277b2fa7dea31d0abeca471374aef4031"),
				InverseQ = bytetool.toArray("5289ba8bbfb0aa2173494ecd333b83f1ad1ae8d18023ac9ab4eaf695a4506861")
			};
			rsacryptoServiceProvider_0.ImportParameters(parameters);
		}

		public static rsautil getInstance()
		{
			if (rsautil_0 == null)
			{
				rsautil_0 = new rsautil();
			}
			return rsautil_0;
		}

		public byte[] getPublicKey()
		{
			return byte_0;
		}

		public byte[] getExponent()
		{
			return byte_1;
		}

		public byte[] decrypt(byte[] _arg1)
		{
			try
			{
				return rsacryptoServiceProvider_0.Decrypt(_arg1, false);
			}
			catch
			{
				return null;
			}
		}
	}
}
