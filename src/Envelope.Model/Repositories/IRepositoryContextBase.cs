using Envelope.Database;
using Envelope.Trace;
using System.Runtime.CompilerServices;

namespace Envelope.Model.Repositories;

public partial interface IRepositoryContextBase
{
	int Save(
		[CallerMemberName] string memberName = "",
		[CallerFilePath] string sourceFilePath = "",
		[CallerLineNumber] int sourceLineNumber = 0);

	int Save(
		ITraceInfo traceInfo,
		[CallerMemberName] string memberName = "",
		[CallerFilePath] string sourceFilePath = "",
		[CallerLineNumber] int sourceLineNumber = 0);

	int Save(
		ITraceInfo? traceInfo,
		SaveOptions? options,
		[CallerMemberName] string memberName = "",
		[CallerFilePath] string sourceFilePath = "",
		[CallerLineNumber] int sourceLineNumber = 0);

	int Save(
		ITraceInfo? traceInfo,
		bool acceptAllChangesOnSuccess,
		[CallerMemberName] string memberName = "",
		[CallerFilePath] string sourceFilePath = "",
		[CallerLineNumber] int sourceLineNumber = 0);

	int Save(
		ITraceInfo? traceInfo,
		bool acceptAllChangesOnSuccess,
		SaveOptions? options,
		[CallerMemberName] string memberName = "",
		[CallerFilePath] string sourceFilePath = "",
		[CallerLineNumber] int sourceLineNumber = 0);

	Task<int> SaveAsync(
		CancellationToken cancellationToken = default,
		[CallerMemberName] string memberName = "",
		[CallerFilePath] string sourceFilePath = "",
		[CallerLineNumber] int sourceLineNumber = 0);

	Task<int> SaveAsync(
		ITraceInfo traceInfo,
		CancellationToken cancellationToken = default,
		[CallerMemberName] string memberName = "",
		[CallerFilePath] string sourceFilePath = "",
		[CallerLineNumber] int sourceLineNumber = 0);

	Task<int> SaveAsync(
		ITraceInfo? traceInfo,
		SaveOptions? options,
		CancellationToken cancellationToken = default,
		[CallerMemberName] string memberName = "",
		[CallerFilePath] string sourceFilePath = "",
		[CallerLineNumber] int sourceLineNumber = 0);

	Task<int> SaveAsync(
		ITraceInfo? traceInfo,
		bool acceptAllChangesOnSuccess,
		CancellationToken cancellationToken = default,
		[CallerMemberName] string memberName = "",
		[CallerFilePath] string sourceFilePath = "",
		[CallerLineNumber] int sourceLineNumber = 0);

	Task<int> SaveAsync(
		ITraceInfo? traceInfo,
		bool acceptAllChangesOnSuccess,
		SaveOptions? options,
		CancellationToken cancellationToken = default,
		[CallerMemberName] string memberName = "",
		[CallerFilePath] string sourceFilePath = "",
		[CallerLineNumber] int sourceLineNumber = 0);
}
