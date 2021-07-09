using Microsoft.Extensions.DependencyInjection;
using System;

namespace PracticeDependencyInjection
{
    public class PracticeDependencyInjection
    {
        public static void Main(string[] args)
        {
            // DIサービスコンテナ生成
            ServiceCollection services = new ServiceCollection();

            // サンプル1：IFを実装するクラスを登録して利用するだけ
            services.AddTransient<IBuisinessLogicA, BuisinessLogicA>();
            using (ServiceProvider provider = services.BuildServiceProvider())
            {
                IBuisinessLogicA buisinessLogicA = provider.GetService<IBuisinessLogicA>();
                buisinessLogicA.Execute();
            }

            // サンプル2：単純なDI
            services.AddTransient<IBuisinessLogicB, BuisinessLogicB>();
            services.AddTransient<IBuisinessLogicC, BuisinessLogicC>();
            using (ServiceProvider provider = services.BuildServiceProvider())
            {
                IBuisinessLogicB buisinessLogicB = provider.GetService<IBuisinessLogicB>();
                buisinessLogicB.Execute();
            }

            // サンプル3：コンストラクタ引数にインターフェース以外のパラメータが存在する場合のDIサービスコンテナ登録方法
            services.AddTransient<IBuisinessLogicD>(x => new BuisinessLogicD(x.GetRequiredService<IBuisinessLogicE>(), "D"));
            services.AddTransient<IBuisinessLogicE, BuisinessLogicE>();
            using (ServiceProvider provider = services.BuildServiceProvider())
            {
                IBuisinessLogicD buisinessLogicD = provider.GetService<IBuisinessLogicD>();
                buisinessLogicD.Execute();
            }
        }
    }
}
