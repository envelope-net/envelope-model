using Envelope.Database;
using Envelope.Trace;
using System.Runtime.CompilerServices;

namespace Envelope.Model.Repositories;

public partial interface IRepositoryContextBase
{
	string? ConnectionId { get; }

	void SetConnectionId(string connectionId);

	Task<int> SaveAsync(
		ITraceInfo traceInfo,
		CancellationToken cancellationToken = default,
		[CallerMemberName] string memberName = "",
		[CallerFilePath] string sourceFilePath = "",
		[CallerLineNumber] int sourceLineNumber = 0);

	Task<int> SaveAsync(
		ITraceInfo traceInfo,
		bool autoCommit,
		CancellationToken cancellationToken = default,
		[CallerMemberName] string memberName = "",
		[CallerFilePath] string sourceFilePath = "",
		[CallerLineNumber] int sourceLineNumber = 0);

	Task<int> SaveAsync(
		ITraceInfo? traceInfo,
		bool autoCommit,
		SaveOptions? options,
		CancellationToken cancellationToken = default,
		[CallerMemberName] string memberName = "",
		[CallerFilePath] string sourceFilePath = "",
		[CallerLineNumber] int sourceLineNumber = 0);

	Task<int> SaveAsync(
		ITraceInfo? traceInfo,
		bool autoCommit,
		bool acceptAllChangesOnSuccess,
		CancellationToken cancellationToken = default,
		[CallerMemberName] string memberName = "",
		[CallerFilePath] string sourceFilePath = "",
		[CallerLineNumber] int sourceLineNumber = 0);

	Task<int> SaveAsync(
		ITraceInfo? traceInfo,
		bool autoCommit,
		bool acceptAllChangesOnSuccess,
		SaveOptions? options,
		CancellationToken cancellationToken = default,
		[CallerMemberName] string memberName = "",
		[CallerFilePath] string sourceFilePath = "",
		[CallerLineNumber] int sourceLineNumber = 0);
}
