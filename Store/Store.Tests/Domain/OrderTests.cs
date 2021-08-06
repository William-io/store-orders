// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using Store.Domain.Entities;

// namespace Store.Tests.Domain
// {
//     [TestClass]
//     public class OrderTests
//     {
//         private readonly Customer _customer = new Customer("William");
//         private readonly Item _item = new Item("Pineapple", 1.5m);

//         [TestMethod]
//         [TestCategory("Domain")]
//         public void Dado_um_novo_pedido_valido_ele_deve_gerar_um_numero_com_8_caracteres()
//         {
//             var order = new Order(_customer);
//             Assert.AreEqual(8, order.OrderNo.Length);
//         }

//         [TestMethod]
//         [TestCategory("Domain")]
//         public void Dado_um_novo_pedido_seu_status_deve_ser_aguardando_pagamento()
//         {
//             var order = new Order(_customer);
//             Assert.AreEqual(order.Status, EOrderStatus.WaitingPayment);
//         }

//     }

// }