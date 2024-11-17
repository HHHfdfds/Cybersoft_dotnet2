using System;

internal class Program
{
    private static void Main(string[] args)
    {
        #region BT1
        // Console.Write("Nhập số lượng phần tử trong mảng: ");
        // int n = Convert.ToInt32(Console.ReadLine());
        // int[] array = new int[n];
        // Console.WriteLine("Nhập các số nguyên vào mảng:");
        // for (int i = 0; i < n; i++)
        // {
        //     Console.Write($"Nhập phần tử thứ {i + 1}: ");
        //     array[i] = Convert.ToInt32(Console.ReadLine());
        // }
        // int sum = 0;
        // foreach (int num in array)
        // {
        //     sum += num;
        // }
        // Console.WriteLine("Tổng các số trong mảng: " + sum);
        #endregion
        #region Bt2
        // Console.Write("Nhập số lượng phần tử của mảng: ");
        // int n = Convert.ToInt32(Console.ReadLine());
        
        // int[] numbers = new int[n];
        // for (int i = 0; i < n; i++)
        // {
        //     Console.Write($"phần tử thứ {i + 1}: ");
        //     numbers[i] = Convert.ToInt32(Console.ReadLine());
        // }
        // Console.Write("Nhập tổng cần tìm: ");
        // int target = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine($"Các cặp số có tổng bằng {target} là:");
        // bool nums = false;

        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     for (int j = i + 1; j < numbers.Length; j++)
        //     {
        //         if (numbers[i] + numbers[j] == target)
        //         {
        //             Console.WriteLine($"({numbers[i]}, {numbers[j]})");
        //             nums = true;
        //         }
        //     }
        // }
        // if (!nums)
        // {
        //     Console.WriteLine("Không có cặp nào có tổng bằng " + target);
        // }
        #endregion
        #region Bt3
        // int[] arr = { 1, 1, 2, 2, 2, 3, 4, 4, 5};
        // int[] uniqueArr = new int[arr.Length];
        // int uniqueCount = 0;
        // for (int i = 0; i < arr.Length; i++)
        // {
        //     bool isDuplicate = false;
        //     for (int j = 0; j < uniqueCount; j++)
        //     {
        //         if (arr[i] == uniqueArr[j])
        //         {
        //             isDuplicate = true;
        //             break;
        //         }
        //     }
        //     if (!isDuplicate)
        //     {
        //         uniqueArr[uniqueCount] = arr[i];
        //         uniqueCount++;
        //     }
        // }
        // for (int i = 0; i < uniqueCount; i++)
        // {
        //     Console.Write(uniqueArr[i] + " ");
        // }
        #endregion
        #region BT4
            int[] mangGoc = {1, 1, 1, 2, 2, 3};
            int k = 2;
            Dictionary<int, int> soLanXuatHien = new Dictionary<int, int>();
            foreach (var phanTu in mangGoc)
            {
                if (soLanXuatHien.ContainsKey(phanTu))
                {
                    soLanXuatHien[phanTu]++;
                }
                else
                {
                    soLanXuatHien[phanTu] = 1;
                }
            }
            List<int> ketQua = new List<int>();
            foreach (var item in soLanXuatHien)
            {
                if (item.Value == k)
                {
                    ketQua.Add(item.Key);
                }
            }
            if (ketQua.Count > 0)
            {
                Console.WriteLine("Các phần tử xuất hiện " + k + " lần là: ");
                Console.WriteLine(string.Join(", ", ketQua));
            }
            else
            {
                Console.WriteLine("Không có phần tử nào xuất hiện " + k + " lần.");
            }
        #endregion
    }

}
