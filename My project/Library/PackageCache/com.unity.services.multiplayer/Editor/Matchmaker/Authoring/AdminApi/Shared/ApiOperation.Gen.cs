
//-----------------------------------------------------------------------------
// <auto-generated>
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

namespace Unity.Services.Multiplayer.Editor.Matchmaker.Authoring.AdminApi.Shared
{
    /// <summary>
    /// API Operation
    /// </summary>
    class ApiOperation
    {
        /// <summary>
        /// Get notified when the operation completes
        /// </summary>
        public event Action<ApiResponse> Completed;

        /// <summary>
        /// Gets a value that indicates whether the task has completed.
        /// </summary>
        public bool IsCompleted { get; protected set; }

        /// <summary>
        /// Gets the response of this operation
        /// </summary>
        public ApiResponse Response { get; protected set; }

        /// <summary>
        /// Gets an awaiter used to await this Task.
        /// </summary>
        public Task<ApiResponse> AsTask => Source.Task;

        readonly TaskCompletionSource<ApiResponse> Source = new TaskCompletionSource<ApiResponse>();

        internal ApiOperation()
        {
        }

        internal ApiOperation(ApiResponse response)
        {
            Complete(response);
        }

        /// <summary>
        /// Gets an awaiter used to await this Task.
        /// </summary>
        /// <returns>An awaiter instance</returns>
        public TaskAwaiter<ApiResponse> GetAwaiter()
        {
            return AsTask.GetAwaiter();
        }

        /// <summary>
        /// Coroutine support to yield for completion
        /// </summary>
        /// <returns>Enumerator to yield to</returns>
        public IEnumerator WaitForCompletion()
        {
            return new WaitUntil(() => IsCompleted);
        }

        internal void Complete(ApiResponse response)
        {
            SetResponse(response);
            SetCompleted(response);
            InvokeCallback(response);
            SetTaskResult(response);
        }

        internal void SetResponse(ApiResponse response)
        {
            Response = response;
        }

        internal void SetCompleted(ApiResponse response)
        {
            IsCompleted = true;
        }

        internal void InvokeCallback(ApiResponse response)
        {
            Completed?.Invoke(response);
        }

        internal void SetTaskResult(ApiResponse response)
        {
            Source.SetResult(response);
        }
    }

    /// <summary>
    /// API Operation
    /// </summary>
    /// <typeparam name="T">The model associated to the response</typeparam>
    class ApiOperation<T> : ApiOperation
    {
        /// <summary>
        /// Get notified when the operation completes
        /// </summary>
        public new event Action<ApiResponse<T>> Completed;

        /// <summary>
        /// Gets the response of this operation
        /// </summary>
        public new ApiResponse<T> Response { get; private set; }

        /// <summary>
        /// Gets an awaiter used to await this Task.
        /// </summary>
        public new Task<ApiResponse<T>> AsTask => Source.Task;

        readonly TaskCompletionSource<ApiResponse<T>> Source = new TaskCompletionSource<ApiResponse<T>>();

        internal ApiOperation()
        {
        }

        internal ApiOperation(ApiResponse<T> response)
        {
            Complete(response);
        }

        /// <summary>
        /// Gets an awaiter used to await this Task.
        /// </summary>
        /// <returns>An awaiter instance</returns>
        public new TaskAwaiter<ApiResponse<T>> GetAwaiter()
        {
            return AsTask.GetAwaiter();
        }

        internal void Complete(ApiResponse<T> response)
        {
            SetResponse(response);
            SetCompleted(response);
            InvokeCallback(response);
            SetTaskResult(response);
        }

        internal void SetResponse(ApiResponse<T> response)
        {
            Response = response;
            base.SetResponse(response);
        }

        internal void SetCompleted(ApiResponse<T> response)
        {
            IsCompleted = true;
            base.SetCompleted(response);
        }

        internal void InvokeCallback(ApiResponse<T> response)
        {
            Completed?.Invoke(response);
            base.InvokeCallback(response);
        }

        internal void SetTaskResult(ApiResponse<T> response)
        {
            Source.SetResult(response);
            base.SetTaskResult(response);
        }
    }
}