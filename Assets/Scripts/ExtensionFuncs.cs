namespace ForOffer.Extension
{
    public static class ExtensionFuncs
    {
        public static void ExchangeIndex<T>(this T[] arr, int index1, int index2)
        {
            T tmp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = tmp;
        }
    }
}