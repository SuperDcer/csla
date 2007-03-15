namespace Csla.Core
{
  /// <summary>
  /// Defines the common methods required by all
  /// editable CSLA collection objects.
  /// </summary>
  /// <remarks>
  /// It is strongly recommended that the implementations
  /// of the methods in this interface be made Private
  /// so as to not clutter up the native interface of
  /// the collection objects.
  /// </remarks>
  [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", 
    "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
  public interface IEditableCollection : IUndoableObject
  {
    /// <summary>
    /// Removes the specified child from the parent
    /// collection.
    /// </summary>
    /// <param name="child">Child object to be removed.</param>
    void RemoveChild(Core.IEditableBusinessObject child);
    /// <summary>
    /// Returns <see langword="true" /> if the collection or
    /// any child object's data in the collection has been changed.
    /// </summary>
    /// <returns>A value indicating if this object's data has been changed.</returns>
    bool IsDirty { get; }
    /// <summary>
    /// Returns <see langword="true" /> if all
    /// child objects are currently valid, <see langword="false" /> if any
    /// child object has broken rules or is otherwise invalid.
    /// </summary>
    /// <returns>A value indicating if the object is currently valid.</returns>
    bool IsValid { get; }
    /// <summary>
    /// Returns <see langword="true" /> if this object is both dirty and valid.
    /// </summary>
    /// <returns>A value indicating if this object is both dirty and valid.</returns>
    bool IsSavable { get; }
  }
}