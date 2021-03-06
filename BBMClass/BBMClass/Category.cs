/***
 * This is an autogenerated file. DO NOT EDIT THIS FILE OR YOUR CHANGES WILL BE OVERWRITTEN! 
 * If you wish to make changes here, please update the documentation in the bbm_doc git 
 * repository and then rerun the updateschema.py2 script. 
 */

using System;
//using com.bbm.bbmds.internal.JsonConstructable;
using com.bbm.util.Existence;

namespace com.bbm.bbmds{
/// <summary>
/// <p>
/// This singleton list holds the set of categories for the user's contact list. The category 
/// list is only a list of categories themselves, it does not contain the contacts contained 
/// within each category. 
/// </p>
/// <p>
/// 
/// The list of users within each category is stored in a categoryContents list whose ID matches 
/// the ID of the category. When a category is deleted, any users in that category will be moved to 
/// another category. If there is only one category, core may refuse to delete it. 
/// </p>
/// <p>
/// 
/// The global variable 'defaultCategory' holds the ID of the default category. This is the 
/// category where newly created contacts are inserted, and where existing contacts are moved 
/// if their category is deleted. The current implementation of core will always make the 
/// default category non-deletable. If this should ever change, it will clear the canDelete 
/// flag from the category. The UI must take care of translating the name of the default 
/// category, see description of the name property for details. 
/// </p>
/// </summary>
public class Category : JsonConstructable {
    /// <summary>
    /// True if and only if the category permits deletions. Read-only (this attribute may be changed by core, but not by the UI).
    /// </summary>
    public bool canDelete = true;
    
    /// <summary>
    /// The unique identifier for this category.
    /// </summary>
    public long id = 0;
    
    /// <summary>
    /// The name of the category. If this is the default category (as indicated by the defaultCategory global) and the name is the string literal "Contacts", then the UI must supply a local-specific translation.
    /// </summary>
    public string name = "";
    
    /// <summary>
    /// Determines whether this element exists in the user list. If state is Existence.YES, this struct contains real data. Otherwise, all other attributes contain default placeholder data. If the state is Existence.NO, then we know for certain that this
    /// entity does not exist in the daemon. If the state is Existence.MAYBE, then we have not yet confirmed whether this entity exists in the daemon -- normally this is because the client has sent out a request to the daemon that it has not yet answered.
    /// </summary>
    public Existence exists = Existence.MAYBE;
    
    
    /// <summary>
    /// Creates a new instance with default values
    /// </summary>
    public Category () {}
    
    /// <summary>
    /// Creates a shallow copy of the argument.
    /// </summary>
    /// <param name="toCopy">the object to copy</param>
    public Category (Category toCopy) {
        canDelete = toCopy.canDelete;
        id = toCopy.id;
        name = toCopy.name;
        exists = toCopy.exists;
    }
    
    
    public override string getPrimaryKey() {
        return String.valueOf(id);
    }
    
    
    public override void setAttributes(JSONObject json) {
    
        canDelete = json.optBoolean("canDelete", canDelete);
        
        if (json.has("id")) {
            id = (long)json.optDouble("id", 0);
        }
        name = json.optString("name", name);
    }
    
    
    public override JsonConstructable shallowCopy() {
        return new Category(this);
    }
    
    public override void setExists(Existence exists) {
        this.exists = exists;
    }
    
    public override Existence getExists() {
        return exists;
    }
    
    
    public override int hashCode() {
    
        int prime = 31;
        int result = 1;
        result = prime * result + (canDelete ? 1231 : 1237);
        result = prime * result + (int)id;
        result = prime * result + ((name == null) ? 0 : name.hashCode());
        result = prime * result + ((exists == null) ? 0 : exists.hashCode());
        return result;
    }
    
    
    public override bool equals(Object obj) {
    
        if (this == obj) {
            return true;
        }
        if (obj == null) {
            return false;
        }
        if (getClass() != obj.getClass()) {
            return false;
        }
        Category other = (Category) obj;
        if (canDelete != (other.canDelete)) {
            return false;
        }
        if (id != (other.id)) {
            return false;
        }
        if (name == null) {
            if (other.name != null) {
                return false;
            }
        } else if (!name.equals(other.name)) {
            return false;
        }
        
        if (!exists.equals(other.exists)) {
            return false;
        }
        
        return true;
    }
}
}