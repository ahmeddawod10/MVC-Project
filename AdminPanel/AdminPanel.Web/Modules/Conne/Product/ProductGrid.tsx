import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ProductColumns, ProductRow, ProductService } from '../../ServerTypes/Conne';
import { ProductDialog } from './ProductDialog';

@Decorators.registerClass('AdminPanel.Conne.ProductGrid')
export class ProductGrid extends EntityGrid<ProductRow> {
    protected getColumnsKey() { return ProductColumns.columnsKey; }
    protected getDialogType() { return ProductDialog; }
    protected getRowDefinition() { return ProductRow; }
    protected getService() { return ProductService.baseUrl; }
}