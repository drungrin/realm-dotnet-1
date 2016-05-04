/* Copyright 2016 Realm Inc - All Rights Reserved
 * Proprietary and Confidential
 */
using System;
using System.Runtime.InteropServices;

namespace Realms
{
    // A NotificationToken in object-store references a Results object.
    // We need to mirror this same relationship here.
    internal class NotificationTokenHandle : RealmHandle
    {
        internal NotificationTokenHandle(ResultsHandle root) : base(root)
        {
        }

        protected override void Unbind()
        {
            IntPtr managedResultsHandle = NativeResults.destroy_notificationtoken(handle);
            GCHandle.FromIntPtr(managedResultsHandle).Free();
        }
    }
}

