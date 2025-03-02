import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { CartRow } from "./CartRow";

export interface CartColumns {
    Id: Column<CartRow>;
    Userid: Column<CartRow>;
    ProductidName: Column<CartRow>;
    Count: Column<CartRow>;
    Price: Column<CartRow>;
}

export class CartColumns extends ColumnsBase<CartRow> {
    static readonly columnsKey = 'Conne.Cart';
    static readonly Fields = fieldsProxy<CartColumns>();
}