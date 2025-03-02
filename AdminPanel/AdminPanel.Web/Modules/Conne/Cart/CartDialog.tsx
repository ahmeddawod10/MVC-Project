import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CartForm, CartRow, CartService } from '../../ServerTypes/Conne';

@Decorators.registerClass('AdminPanel.Conne.CartDialog')
export class CartDialog extends EntityDialog<CartRow, any> {
    protected getFormKey() { return CartForm.formKey; }
    protected getRowDefinition() { return CartRow; }
    protected getService() { return CartService.baseUrl; }

    protected form = new CartForm(this.idPrefix);
}