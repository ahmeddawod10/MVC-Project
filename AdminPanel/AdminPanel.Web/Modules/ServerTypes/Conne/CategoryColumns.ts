import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { CategoryRow } from "./CategoryRow";

export interface CategoryColumns {
    Id: Column<CategoryRow>;
    Name: Column<CategoryRow>;
    Description: Column<CategoryRow>;
    Photo: Column<CategoryRow>;
}

export class CategoryColumns extends ColumnsBase<CategoryRow> {
    static readonly columnsKey = 'Conne.Category';
    static readonly Fields = fieldsProxy<CategoryColumns>();
}