
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moralis.Platform.Utilities
{
    /// <summary>
    /// Provides helper methods that allow us to use terser code elsewhere.
    /// </summary>
    public static class InternalExtensions
    {
        /// <summary>
        /// Ensures a task (even null) is awaitable.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="task"></param>
        /// <returns></returns>
        public static Task<T> Safe<T>(this Task<T> task)
        {
            if (task is { })
                return task;
            else
                return Task.FromResult(default(T));
        }

        /// <summary>
        /// Ensures a task (even null) is awaitable.
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public static Task Safe(this Task task)
        {

            if (task is { })
                return task;
            else
                return Task.FromResult<object>(null);
        }

        public delegate void PartialAccessor<T>(ref T arg);

        public static TValue GetOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> self,
            TKey key,
            TValue defaultValue)
        {
            if (self.TryGetValue(key, out TValue value))
                return value;
            return defaultValue;
        }

        public static bool CollectionsEqual<T>(this IEnumerable<T> a, IEnumerable<T> b) => Equals(a, b) ||
                   a != null && b != null &&
                   a.SequenceEqual(b);

        public static async void Wait<T>(this Task<T> task) //=> task.ContinueWith(t =>
        {
            if (TaskStatus.Running.Equals(task.Status))
            {
                await task;
            }
        }

        public static async Task<T> Result<T>(this Task<T> task)
        {
            Task<T> result = default;

            if (TaskStatus.Running.Equals(task.Status))
                await task;

            if (!task.Status.Equals(TaskStatus.Faulted) && !task.Status.Equals(TaskStatus.Canceled))
            {
                result = task;
            }

            return result.GetAwaiter().GetResult();
        }
		
		
        //public static Task WhileAsync(Func<Task<bool>> predicate, Func<Task> body)
        //{
        //    Func<Task> iterate = null;
        //    iterate = () => predicate().OnSuccess(t =>
        //        {
        //            if (!t.Result)
        //                return Task.FromResult(0);
        //            return body().OnSuccess(_ => iterate()).Unwrap();
        //        }).Unwrap();
        //    return iterate();
        //}
    }
}
