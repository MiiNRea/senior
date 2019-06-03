﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sproject.Migrations
{
    public partial class c1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerInfos",
                columns: table => new
                {
                    customerinfo_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    customer_name = table.Column<string>(nullable: false),
                    phone_number = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerInfos", x => x.customerinfo_id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrders",
                columns: table => new
                {
                    purchase_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    purchase_date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrders", x => x.purchase_id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderTypes",
                columns: table => new
                {
                    Purchase_type_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Purchase_type_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderTypes", x => x.Purchase_type_id);
                });

            migrationBuilder.CreateTable(
                name: "SupplierTypes",
                columns: table => new
                {
                    supplier_type_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    supplier_type_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierTypes", x => x.supplier_type_id);
                });

            migrationBuilder.CreateTable(
                name: "SupplierInfos",
                columns: table => new
                {
                    supplier_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    supplier_name = table.Column<string>(nullable: false),
                    supplier_person = table.Column<string>(nullable: true),
                    supplier_phone = table.Column<string>(nullable: true),
                    supplier_address = table.Column<string>(nullable: true),
                    supplier_type_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierInfos", x => x.supplier_id);
                    table.ForeignKey(
                        name: "FK_SupplierInfos_SupplierTypes_supplier_type_id",
                        column: x => x.supplier_type_id,
                        principalTable: "SupplierTypes",
                        principalColumn: "supplier_type_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInfos",
                columns: table => new
                {
                    product_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    product_name = table.Column<string>(nullable: false),
                    product_series = table.Column<string>(nullable: false),
                    product_size = table.Column<string>(nullable: false),
                    supplier_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInfos", x => x.product_id);
                    table.ForeignKey(
                        name: "FK_ProductInfos_SupplierInfos_supplier_id",
                        column: x => x.supplier_id,
                        principalTable: "SupplierInfos",
                        principalColumn: "supplier_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Borrows",
                columns: table => new
                {
                    borrow_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    supplier_id = table.Column<int>(nullable: false),
                    product_id = table.Column<int>(nullable: false),
                    borrow_qty = table.Column<int>(nullable: false),
                    borrow_date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrows", x => x.borrow_id);
                    table.ForeignKey(
                        name: "FK_Borrows_ProductInfos_product_id",
                        column: x => x.product_id,
                        principalTable: "ProductInfos",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Borrows_SupplierInfos_supplier_id",
                        column: x => x.supplier_id,
                        principalTable: "SupplierInfos",
                        principalColumn: "supplier_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerOrders",
                columns: table => new
                {
                    customerOrder_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    customerorder_date = table.Column<DateTime>(nullable: false),
                    customerorder_qty = table.Column<int>(nullable: false),
                    product_id = table.Column<int>(nullable: false),
                    customerinfo_id = table.Column<int>(nullable: false),
                    warranty_time = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerOrders", x => x.customerOrder_id);
                    table.ForeignKey(
                        name: "FK_CustomerOrders_CustomerInfos_customerinfo_id",
                        column: x => x.customerinfo_id,
                        principalTable: "CustomerInfos",
                        principalColumn: "customerinfo_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerOrders_ProductInfos_product_id",
                        column: x => x.product_id,
                        principalTable: "ProductInfos",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    inventory_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    product_id = table.Column<int>(nullable: false),
                    product_name = table.Column<string>(nullable: true),
                    invento_qty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.inventory_id);
                    table.ForeignKey(
                        name: "FK_Inventories_ProductInfos_product_id",
                        column: x => x.product_id,
                        principalTable: "ProductInfos",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseItems",
                columns: table => new
                {
                    purchaseItem_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    purchase_cost = table.Column<double>(nullable: false),
                    purchase_type_id = table.Column<int>(nullable: false),
                    product_id = table.Column<int>(nullable: false),
                    qty = table.Column<int>(nullable: false),
                    selling_price = table.Column<double>(nullable: false),
                    purchase_id = table.Column<int>(nullable: false),
                    supplier_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseItems", x => x.purchaseItem_id);
                    table.ForeignKey(
                        name: "FK_PurchaseItems_ProductInfos_product_id",
                        column: x => x.product_id,
                        principalTable: "ProductInfos",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseItems_PurchaseOrders_purchase_id",
                        column: x => x.purchase_id,
                        principalTable: "PurchaseOrders",
                        principalColumn: "purchase_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseItems_PurchaseOrderTypes_purchase_type_id",
                        column: x => x.purchase_type_id,
                        principalTable: "PurchaseOrderTypes",
                        principalColumn: "Purchase_type_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseItems_SupplierInfos_supplier_id",
                        column: x => x.supplier_id,
                        principalTable: "SupplierInfos",
                        principalColumn: "supplier_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Warranties",
                columns: table => new
                {
                    warranty_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    customerOrder_id = table.Column<int>(nullable: false),
                    problem = table.Column<string>(nullable: true),
                    claim_date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warranties", x => x.warranty_id);
                    table.ForeignKey(
                        name: "FK_Warranties_CustomerOrders_customerOrder_id",
                        column: x => x.customerOrder_id,
                        principalTable: "CustomerOrders",
                        principalColumn: "customerOrder_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BackOrders",
                columns: table => new
                {
                    backOrder_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    purchaseItem_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackOrders", x => x.backOrder_id);
                    table.ForeignKey(
                        name: "FK_BackOrders_PurchaseItems_purchaseItem_id",
                        column: x => x.purchaseItem_id,
                        principalTable: "PurchaseItems",
                        principalColumn: "purchaseItem_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InventoryIn",
                columns: table => new
                {
                    inventoryin_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    purchase_id = table.Column<int>(nullable: false),
                    product_id = table.Column<int>(nullable: false),
                    inventoryin_qty = table.Column<int>(nullable: false),
                    manufacturer_week = table.Column<int>(nullable: false),
                    manufacturer_year = table.Column<int>(nullable: false),
                    purchaseItem_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryIn", x => x.inventoryin_id);
                    table.ForeignKey(
                        name: "FK_InventoryIn_ProductInfos_product_id",
                        column: x => x.product_id,
                        principalTable: "ProductInfos",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InventoryIn_PurchaseItems_purchaseItem_id",
                        column: x => x.purchaseItem_id,
                        principalTable: "PurchaseItems",
                        principalColumn: "purchaseItem_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InventoryIn_PurchaseOrders_purchase_id",
                        column: x => x.purchase_id,
                        principalTable: "PurchaseOrders",
                        principalColumn: "purchase_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PActivities",
                columns: table => new
                {
                    activity_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    purchase_type_id = table.Column<int>(nullable: false),
                    purchaseItem_id = table.Column<int>(nullable: false),
                    activity_date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PActivities", x => x.activity_id);
                    table.ForeignKey(
                        name: "FK_PActivities_PurchaseItems_purchaseItem_id",
                        column: x => x.purchaseItem_id,
                        principalTable: "PurchaseItems",
                        principalColumn: "purchaseItem_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PActivities_PurchaseOrderTypes_purchase_type_id",
                        column: x => x.purchase_type_id,
                        principalTable: "PurchaseOrderTypes",
                        principalColumn: "Purchase_type_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplierPerformances",
                columns: table => new
                {
                    SupplierPerformance_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    supplier_id = table.Column<int>(nullable: false),
                    purchaseItem_id = table.Column<int>(nullable: false),
                    deliver_date = table.Column<DateTime>(nullable: false),
                    leadTime = table.Column<int>(nullable: false),
                    backOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierPerformances", x => x.SupplierPerformance_id);
                    table.ForeignKey(
                        name: "FK_SupplierPerformances_PurchaseItems_purchaseItem_id",
                        column: x => x.purchaseItem_id,
                        principalTable: "PurchaseItems",
                        principalColumn: "purchaseItem_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierPerformances_SupplierInfos_supplier_id",
                        column: x => x.supplier_id,
                        principalTable: "SupplierInfos",
                        principalColumn: "supplier_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BackOrders_purchaseItem_id",
                table: "BackOrders",
                column: "purchaseItem_id");

            migrationBuilder.CreateIndex(
                name: "IX_Borrows_product_id",
                table: "Borrows",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Borrows_supplier_id",
                table: "Borrows",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOrders_customerinfo_id",
                table: "CustomerOrders",
                column: "customerinfo_id");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOrders_product_id",
                table: "CustomerOrders",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_product_id",
                table: "Inventories",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryIn_product_id",
                table: "InventoryIn",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryIn_purchaseItem_id",
                table: "InventoryIn",
                column: "purchaseItem_id");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryIn_purchase_id",
                table: "InventoryIn",
                column: "purchase_id");

            migrationBuilder.CreateIndex(
                name: "IX_PActivities_purchaseItem_id",
                table: "PActivities",
                column: "purchaseItem_id");

            migrationBuilder.CreateIndex(
                name: "IX_PActivities_purchase_type_id",
                table: "PActivities",
                column: "purchase_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInfos_supplier_id",
                table: "ProductInfos",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseItems_product_id",
                table: "PurchaseItems",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseItems_purchase_id",
                table: "PurchaseItems",
                column: "purchase_id");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseItems_purchase_type_id",
                table: "PurchaseItems",
                column: "purchase_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseItems_supplier_id",
                table: "PurchaseItems",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierInfos_supplier_type_id",
                table: "SupplierInfos",
                column: "supplier_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPerformances_purchaseItem_id",
                table: "SupplierPerformances",
                column: "purchaseItem_id");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPerformances_supplier_id",
                table: "SupplierPerformances",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "IX_Warranties_customerOrder_id",
                table: "Warranties",
                column: "customerOrder_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BackOrders");

            migrationBuilder.DropTable(
                name: "Borrows");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "InventoryIn");

            migrationBuilder.DropTable(
                name: "PActivities");

            migrationBuilder.DropTable(
                name: "SupplierPerformances");

            migrationBuilder.DropTable(
                name: "Warranties");

            migrationBuilder.DropTable(
                name: "PurchaseItems");

            migrationBuilder.DropTable(
                name: "CustomerOrders");

            migrationBuilder.DropTable(
                name: "PurchaseOrders");

            migrationBuilder.DropTable(
                name: "PurchaseOrderTypes");

            migrationBuilder.DropTable(
                name: "CustomerInfos");

            migrationBuilder.DropTable(
                name: "ProductInfos");

            migrationBuilder.DropTable(
                name: "SupplierInfos");

            migrationBuilder.DropTable(
                name: "SupplierTypes");
        }
    }
}