class List

  def add_value(value)
    @item.add_item(value)
  end

  def get_value(index)
  end

  def remove_value(index)
  end

  def next_element
  end

  def first_element
  end

  def last_element
  end

  def count
  end
end


class ListItem
  def add_item(value)
    if @next_value == nil
      @next_value = ListItem.new(value)    
    else 
      @next_value.add_item(value) 
    end
  end

  def get_item
  end

  def remove_item
  end

  def next_item
  end
end


###################################################################
a = List.new
a.add_value("cat")