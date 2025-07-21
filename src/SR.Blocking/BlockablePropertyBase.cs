using SR.Abstraction;
using SR.Blocking.Abstraction;
using System;

namespace SR.Blocking;

/// <summary>
/// Provides a base implementation of <see cref="IBlockableProperty{T}"/> with version tracking
/// and weak reference support for blocked getters.
/// </summary>
/// <typeparam name="T">The type of the property value.</typeparam>
/// <remarks>
/// This implementation uses version tracking and weak references to prevent memory leaks
/// while maintaining access control through blocked getters.
/// </remarks>
public abstract class BlockablePropertyBase<T> : IBlockableProperty<T>
{
    private int m_Version;

    /// <summary>
    /// Gets the current value of the property.
    /// </summary>
    /// <returns>The current property value.</returns>
    public abstract T Get();

    /// <summary>
    /// Attempts to set a new value for the property.
    /// </summary>
    /// <param name="value">The new value to set.</param>
    /// <returns>
    /// <c>true</c> if the value was successfully set; otherwise, <c>false</c>.
    /// </returns>
    /// <remarks>
    /// On successful set operations, increments the internal version counter.
    /// </remarks>
    public bool Set(T value)
    {
        if(!InternalSet(value)) return false;
        m_Version++;
        return true;
    }

    /// <summary>
    /// When implemented in a derived class, performs the actual set operation.
    /// </summary>
    /// <param name="value">The new value to set.</param>
    /// <returns>
    /// <c>true</c> if the value was successfully stored; otherwise, <c>false</c>.
    /// </returns>
    protected abstract bool InternalSet(T value);

    /// <summary>
    /// Creates a new blocked getter instance tied to the current property version.
    /// </summary>
    /// <returns>
    /// An <see cref="IBlockedGetter{T}"/> that validates version consistency
    /// and maintains only a weak reference to the property.
    /// </returns>
    public IGetter<T> GetBlockedGetter() => new BlockedGetter(this, m_Version);

    private class BlockedGetter(BlockablePropertyBase<T> property, int version) : IBlockedGetter<T>
    {
        private readonly WeakReference<BlockablePropertyBase<T>> m_WeakProperty = new(property);

        /// <inheritdoc/>
        public bool CanAccess => InternalCanAccess(out _);

        /// <inheritdoc/>
        public T Get() => InternalCanAccess(out var prop) ? prop.Get() : throw new InvalidOperationException();

        private bool InternalCanAccess(out BlockablePropertyBase<T> prop) => m_WeakProperty.TryGetTarget(out prop) && prop.m_Version == version;
    }
}