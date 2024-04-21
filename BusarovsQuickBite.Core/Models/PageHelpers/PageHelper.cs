namespace BusarovsQuckBite.Models.PageHelpers
{
    public static class PageHelper
    {
        public static List<T> CalculateItemsForPage<T>(int page,int pageSize,IList<T> model)
        {
            List<T> entity = model.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return entity;
        }
        public static int CalculateTotalPages<T>(int pageSize, IList<T> model) where T : class
        {
            return (int)Math.Ceiling((double)(model.Count) / pageSize);
        }
    }
}
