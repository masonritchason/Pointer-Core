using Pointer.Core.Enums;

namespace Pointer.Core.Models;

/// <summary>
/// A submitted Change with information regarding its status in the request process.
/// </summary>
public class ChangeRequest
{
    /// <summary>
    /// The GUID of the requester of the ChangeRequest.
    /// </summary>
    private readonly Guid RequesterId;

    /// <summary>
    /// Allows the ChangeRequest to be created in "Forced" mode, which will automatically approve all Changes.
    /// </summary>
    private readonly bool IsForced = false;

    /// <summary>
    /// The unique identifier number of the ChangeRequest.
    /// </summary>
    private readonly int RequestId;

    /// <summary>
    /// The accepted status of the ChangeRequest.
    /// </summary>
    public bool IsAccepted = false;

    /// <summary>
    /// The completion status of the ChangeRequest.
    /// </summary>
    public ChangeStatus Status;

    /// <summary>
    /// All of the Changes that are required to complete the ChangeRequest.
    /// </summary>
    public IEnumerable<Change> Changes;

    /// <summary>
    /// The remarks made by the requester of the ChangeRequest.
    /// </summary>
    public string Notes;

    /// <summary>
    /// Creates a new ChangeRequest.
    /// </summary>
    /// <param name="requester"></param>
    /// <param name="requestId"></param>
    /// <param name="changes"></param>
    /// <param name="notes"></param>
    /// <exception cref="ArgumentException"></exception>
    public ChangeRequest(Guid requester, int requestId, IEnumerable<Change> changes, string notes)
    {
        if (false)  // if requester is in forceable list
        {
            // IsForced = true;
        }
        if (IsForced)
        {
            IsAccepted = true;
        }
        if (!changes.Any())
        {
            throw new ArgumentException("Cannot create a ChangeRequest without at least one Change.", nameof(changes));
        }
        RequestId = requestId;
        Status = ChangeStatus.Submitted;
        RequesterId = requester;
        Changes = changes;
        Notes = notes;
    }
}