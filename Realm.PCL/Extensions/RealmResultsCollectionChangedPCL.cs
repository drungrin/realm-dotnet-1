/* Copyright 2016 Realm Inc - All Rights Reserved
 * Proprietary and Confidential
 */

using System;
using System.Collections.Specialized;

namespace Realms
{
    public static class RealmResultsCollectionChanged
    {
        /// <summary>
        /// Wraps a <see cref="RealmResults{T}" /> in an implementation of <see cref="INotifyCollectionChanged" /> so that it may be used in MVVM databinding.
        /// </summary>
        /// <param name="results">The <see cref="RealmResults{T}"/ > to observe for changes.</param>
        /// <param name="errorCallback">An error callback that will be invoked if the observing thread raises an error.</param>
        /// <returns>An <see cref="ObservableCollection{T}" />-like object useful for MVVM databinding.</returns>
        /// <seealso cref="RealmResults{T}.SubscribeForNotifications(RealmResults{T}.NotificationCallback)"/>
        public static INotifyCollectionChanged ToNotifyCollectionChanged<T>(this RealmResults<T> results, Action<Exception> errorCallback) where T : RealmObject
        {
            RealmPCLHelpers.ThrowProxyShouldNeverBeUsed();
            return null;
        }

        /// <summary>
        /// Wraps a <see cref="RealmResults{T}" /> in an implementation of <see cref="INotifyCollectionChanged" /> so that it may be used in MVVM databinding.
        /// </summary>
        /// <param name="results">The <see cref="RealmResults{T}"/ > to observe for changes.</param>
        /// <param name="errorCallback">An error callback that will be invoked if the observing thread raises an error.</param>
        /// <param name="coalesceMultipleChangesIntoReset">
        /// When a lot of items have been added or removed at once it is more efficient to raise <see cref="INotifyCollectionChanged.CollectionChanged" /> once
        /// with <see cref="NotifyCollectionChangedAction.Reset" /> instead of multiple times for every single change. Pass <c>true</c> to opt-in to this behavior.
        /// </param>
        /// <returns>An <see cref="ObservableCollection{T}" />-like object useful for MVVM databinding.</returns>
        /// <seealso cref="RealmResults{T}.SubscribeForNotifications(RealmResults{T}.NotificationCallback)"/>
        public static INotifyCollectionChanged ToNotifyCollectionChanged<T>(this RealmResults<T> results, Action<Exception> errorCallback, bool coalesceMultipleChangesIntoReset) where T : RealmObject
        {
            RealmPCLHelpers.ThrowProxyShouldNeverBeUsed();
            return null;
        }
    }
}
