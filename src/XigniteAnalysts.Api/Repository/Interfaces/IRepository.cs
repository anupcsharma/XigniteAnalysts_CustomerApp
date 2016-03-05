namespace XigniteAnalysts.Api.Repository.Interfaces
{
	/// <summary>
	/// Repository with basics operations
	/// </summary>
	/// <typeparam name="T">Entity object for repository</typeparam>
	public interface IRepository<T, TKey>
	{
		/// <summary>
		/// Gets the object by specified identifier (for example MSFT).
		/// </summary>
		/// <param name="id">The identifier of object.</param>
		/// <returns>Loaded object</returns>
		T Get(TKey id);
	}
}
