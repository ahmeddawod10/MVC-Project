import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { CartColumns, CartRow, CartService } from '../../ServerTypes/Conne';
import { CartDialog } from './CartDialog';

@Decorators.registerClass('AdminPanel.Conne.CartGrid')
export class CartGrid extends EntityGrid<CartRow> {
    protected getColumnsKey() { return CartColumns.columnsKey; }
    protected getDialogType() { return CartDialog; }
    protected getRowDefinition() { return CartRow; }
    protected getService() { return CartService.baseUrl; }
}