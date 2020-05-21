using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    int[] nums = new int[20];
    // Искомое число заранее добавил в массив, для удобства
    nums[0] = 20;
    int searchedItem = nums[0];

    // Добавление рандомных чисел в массив
    Random rnd = new Random();
    for(int i = 1; i < nums.Length; i++)
      nums[i] = rnd.Next(-1,100);

    // Сортировка по возрастанию
    Array.Sort(nums);

    // Вывод всех элементов массива
    for(int i = 0; i < nums.Length; i++)
      Console.WriteLine(nums[i]);

    // Вместо searchedItem можно написать любое число от 0 до 100
    Console.WriteLine("Искомый элемент на "+ Binary(nums, searchedItem, 0, nums.Length) + " позиции.");
  }

  static int Binary(int[] arr, int item, int left, int right){
    // Пока левая и правая части массива не сошлись вместе
    while (left <= right)
    {
        // Индекс среднего элемента
        var mid = left + (right - left) / 2;

        // Элемент найден
        if (item == arr[mid])
            return mid;
        // Много, сужаем интервал поиска с правой стороны массива
        else if (item < arr[mid])
            right = mid - 1;
        // Мало, сужаем интервал поиска с левой стороны массива
        else
            left = mid + 1;
    }
    // Искомого элемента нет в массиве
    return -1;
  }
}