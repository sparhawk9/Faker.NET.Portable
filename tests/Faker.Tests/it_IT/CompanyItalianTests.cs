﻿using NUnit.Framework;

namespace Faker.Tests.it_IT
{
	[SetUICulture("it-IT")]
	[SetCulture("it-IT")]
	[Category("Culture 'it_IT'")]
	public class CompanyItalianTests
	{
		[Test]
		[Repeat(1000)]
		public void Should_Generate_Bullshit()
		{
			string bs1Format = Resources.Company.BS1.ToFormat();
			string bs2Format = Resources.Company.BS2.ToFormat();
			string bs3Format = Resources.Company.BS3.ToFormat();

			string bs = Company.Bullshit();

			bs.AssertFormats(bs1Format.Combine(bs2Format, bs3Format));
		}

		[Test]
		[Repeat(1000)]
		public void Should_Generate_Catchphrase()
		{
			string catch1Format = Resources.Company.Buzzwords1.ToFormat();
			string catch2Format = Resources.Company.Buzzwords2.ToFormat();
			string catch3Format = Resources.Company.Buzzwords3.ToFormat();

			string catchPhrase = Company.CatchPhrase();

			catchPhrase.AssertFormats(catch1Format.Combine(catch2Format, catch3Format));
		}

		[Test]
		[Repeat(1000)]
		public virtual void Should_Generate_Company_Name()
		{
			string firstNameFormat = Resources.Name.First.ToFormat();
			string lastNameFormat = Resources.Name.Last.ToFormat();
			string suffixCompanyFormat = Resources.Company.Suffix.ToFormat();

			string name = Company.Name();

			name.AssertFormats(
							   firstNameFormat.Combine(lastNameFormat, suffixCompanyFormat),
							   lastNameFormat + "-" + lastNameFormat + " " + suffixCompanyFormat,
							   lastNameFormat + " e " + lastNameFormat + " " + suffixCompanyFormat,
							   lastNameFormat + ", " + lastNameFormat + " e " + lastNameFormat + " " + suffixCompanyFormat);
		}
	}
}
