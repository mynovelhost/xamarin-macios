﻿//
// Unit tests for MSMessage
//
// Authors:
//	Vincent Dondain <vincent@xamarin.com>
//
// Copyright 2016 Xamarin Inc. All rights reserved.
//

#if !__TVOS__ && !__WATCHOS__ && !MONOMAC

using System;
using Foundation;
using Messages;
using ObjCRuntime;
using NUnit.Framework;

namespace MonoTouchFixtures.Messages
{

	[TestFixture]
	[Preserve (AllMembers = true)]
	public class MSMessageTest
	{
		[SetUp]
		public void MinimumSdkCheck ()
		{
			TestRuntime.AssertXcodeVersion (8, 0);
			// Mac Catalyst system versions follow the macOS system versions, and Messages was introduced to Mac Catalyst later than for the other frameworks, so we have this additional check
			TestRuntime.AssertSystemVersion (PlatformName.MacCatalyst, 11, 0, throwIfOtherPlatform: false);
		}

		[Test]
		public void InitWithSession ()
		{
			var session = new MSSession ();
			using (var msg = new MSMessage (session)) {
				Assert.That (msg.Session, Is.EqualTo (session), "Session");
				Assert.That (msg.Handle, Is.Not.EqualTo (IntPtr.Zero), "Handle");
			}
		}
	}
}

#endif // !__TVOS__ && !__WATCHOS__
