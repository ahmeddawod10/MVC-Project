import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { CategoryColumns, CategoryRow, CategoryService } from '../../ServerTypes/Conne';
import { CategoryDialog } from './CategoryDialog';

@Decorators.registerClass('AdminPanel.Conne.CategoryGrid')
export class CategoryGrid extends EntityGrid<CategoryRow> {
    protected getColumnsKey() { return CategoryColumns.columnsKey; }
    protected getDialogType() { return CategoryDialog; }
    protected getRowDefinition() { return CategoryRow; }
    protected getService() { return CategoryService.baseUrl; }
}