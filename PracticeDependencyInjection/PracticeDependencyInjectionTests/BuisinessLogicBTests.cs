using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeDependencyInjection;

namespace PracticeDependencyInjectionTests
{
    /// <summary>
    /// DIコンテナを利用してテスト対象のクラスが依存しているクラスをモックに差し替えるサンプル
    /// </summary>
    [TestClass]
    public class BuisinessLogicBTests
    {
        [TestMethod]
        public void ExecuteTests_resultが0の場合()
        {
            // DIサービスコンテナへの登録
            ServiceCollection services = new ServiceCollection();
            services.AddTransient<IBuisinessLogicB, BuisinessLogicB>();
            services.AddTransient<IBuisinessLogicC, BuisinessLogicC_Mock1>();

            using (ServiceProvider provider = services.BuildServiceProvider())
            {
                IBuisinessLogicB buisinessLogicB = provider.GetService<IBuisinessLogicB>();
                buisinessLogicB.Execute();

                // テスト結果判定
                Assert.AreEqual("0です", buisinessLogicB.Msg);
            }
        }

        [TestMethod]
        public void ExecuteTests_resultが1の場合()
        {
            // DIサービスコンテナへの登録
            ServiceCollection services = new ServiceCollection();
            services.AddTransient<IBuisinessLogicB, BuisinessLogicB>();
            services.AddTransient<IBuisinessLogicC, BuisinessLogicC_Mock2>();

            using (ServiceProvider provider = services.BuildServiceProvider())
            {
                IBuisinessLogicB buisinessLogicB = provider.GetService<IBuisinessLogicB>();
                buisinessLogicB.Execute();

                // テスト結果判定
                Assert.AreEqual("1です", buisinessLogicB.Msg);
            }
        }
    }

    // モック
    public class BuisinessLogicC_Mock1 : IBuisinessLogicC
    {
        public int GetRandomInt()
        {
            return 0;
        }
    }

    public class BuisinessLogicC_Mock2 : IBuisinessLogicC
    {
        public int GetRandomInt()
        {
            return 1;
        }
    }
}
