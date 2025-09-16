using System;

public enum OrderStatus
{
    Pending,   // 0
    Shipped,   // 1
    Delivered, // 2
    Cancelled  // 3
}

class Program
{
    static void Main()
    {
        // 初始狀態：Pending
        OrderStatus status = OrderStatus.Pending;
        Console.WriteLine($"訂單狀態：{status}");

        // 模擬付款完成
        status = OrderStatus.Shipped;
        Console.WriteLine($"付款完成，訂單狀態：{status}");
        Notify(status);

        // 模擬貨物送到
        status = OrderStatus.Delivered;
        Console.WriteLine($"貨物送達，訂單狀態：{status}");
        Notify(status);

        // 模擬訂單取消
        status = OrderStatus.Cancelled;
        Console.WriteLine($"訂單取消，訂單狀態：{status}");
        Notify(status);
    }

    // 根據訂單狀態通知對應人員
    static void Notify(OrderStatus status)
    {
        switch (status)
        {
            case OrderStatus.Pending:
                Console.WriteLine("等待付款");
                break;
            case OrderStatus.Shipped:
                Console.WriteLine("通知物流");
                break;
            case OrderStatus.Delivered:
                Console.WriteLine("通知客戶");
                break;
            case OrderStatus.Cancelled:
                Console.WriteLine("訂單已取消，通知客服");
                break;
        }
    }
}
